
var editProfileID = 0;
var editName = "";
var editPassword = "";
var userTable;
var transactionHistory;

// Load the admin profile details
function loadAdminProfileDetails() {

    // Define the API URL with the current username
    var apiUrl = '/api/admindashboard/' + currentUsername;
    console.log("Loading Details for " + currentUsername);

    fetch(apiUrl)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json(); // Expect JSON data
        })
        .then(data => {
            // Update the CSHTML fields with the data from the API
            profileID = data.profileID;
            document.getElementById('adminName').value = currentUsername;
            document.getElementById('adminEmail').value = data.email;

            document.getElementById('adminPhone').value = data.phone;
            document.getElementById('adminAddress').value = data.address;
            document.getElementById('adminPassword').value = password;

            if (data.picture) { // Display profile picture
                base64String = data.picture;
                const imageUrl = `data:image/png;base64,${base64String}`;
                document.getElementById('adminPicture').src = imageUrl; // Set image source
            }

            loadAdminTables();
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });

}

// Load admin tables
function loadAdminTables() {
    var apiUrl = '/api/admindashboard';
    console.log("Loading Details for all users");

    fetch(apiUrl)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json(); // Expect JSON data
        })
        .then(data => {
            // Populate the table with user data
            userTable = document.getElementById('userTable');
            userTable.innerHTML = ''; // Clear existing rows

            data.userProfileList.forEach(userProfile => {
                const row = document.createElement('tr');
                row.innerHTML = `
                    <td>${userProfile.name}</td>
                    <td>${userProfile.email}</td>
                    <td>${userProfile.phone}</td>
                    <td>${userProfile.userProfileId}</td>
                    <td>
                        <button type="button" onclick="editUser('${userProfile.name}')"> Edit </button>
                        <button type="button" onclick="deactivateUserProfile(${parseInt(userProfile.userProfileId)})"> Deactivate </button>
                        <button type ="button" onclick="resetUserPassword(${parseInt(userProfile.userProfileId)})"> Reset Password </button>
                    </td>
                `;
                userTable.appendChild(row);

                apiUrl = '/api/userdashboard/' + userProfile.name;
                console.log("Getting Transaction Details for " + userProfile.name);

                fetch(apiUrl)
                    .then(response => {
                        if (!response.ok) {
                            throw new Error('Network response was not ok');
                        }
                        return response.json(); // Expect JSON data
                    })
                    .then(data => {
                        // Populate the table with transaction data
                        transactionHistory = document.getElementById('transactionHistory');
                        data.transactionsList.forEach(transaction => {
                            const row = document.createElement('tr');
                            row.innerHTML = `
                                <td>${data.name}</td>
                                <td>${data.accountNo}</td>
                                <td>${transaction.transactionDate}</td>
                                <td>$ ${transaction.amount}</td>
                                <td>${transaction.transactionType}</td>
                            `;
                            transactionHistory.appendChild(row);
                        });
                    })
                    .catch(error => {
                        console.error('Fetch error:', error);
                    });
            });
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });
}

// Reset user password
function resetUserPassword(id) {
    // Get form values
    const fullName = document.getElementById('editName').value;
    const email = document.getElementById('editEmail').value;
    const phone = document.getElementById('editPhone').value;
    const address = document.getElementById('editAddress').value;

    if (fullName == "" || email == "")
    {
        alert('Reset Password after Editing User');
        return;
    }
    // Create the data object
    const userProfileData = {
        userProfileID: id,
        name: fullName,
        email: email,
        address: address,
        phone: phone,
        picture: base64String,
        password: "password123"
    };

    var apiUrl = '/api/userdashboard/update'

    // Make the API call to update the user profile
    fetch(apiUrl, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(userProfileData)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Error resetting password');
            }
        })
        .then(data => {
            console.log('Password reset successfully:', data);
            alert('Password reset successful!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('There was an error resetting the password.');
        });

}

// Deactivate user profile
function deactivateUserProfile(id) {
    var apiUrl = '/api/userdashboard/' + id;
    console.log("Deleting user id" + id);

    // Make the API call to update the user profile
    fetch(apiUrl, {
        method: 'DELETE', // Use DELETE method for removal
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            alert('User was deleted.'); // Expect JSON data
            updateUserList();
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });
}

// Update current user list
function updateUserList() {
    apiUrl = '/api/admindashboard';
    console.log("Updating list of active users");

    // Make the API call to GET list of users
    fetch(apiUrl)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json(); // Expect JSON data
        })
        .then(data => {
            // Populate the table with user data
            userTable.innerHTML = ''; // Clear existing rows
            data.userProfileList.forEach(userProfile => {

                const row = document.createElement('tr');
                row.innerHTML = `
                    <td>${userProfile.name}</td >
                    <td>${userProfile.email}</td>
                    <td>${userProfile.phone}</td>
                    <td>${userProfile.userProfileId}</td>
                    <td>
                        <button type="button" onclick="editUser('${userProfile.name}')"> Edit </button>
                        <button type="button" onclick="deactivateUserProfile(${parseInt(userProfile.userProfileId)})"> Deactivate </button>
                        <button type ="button" onclick="resetUserPassword(${parseInt(userProfile.userProfileId)})"> Reset Password </button>
                    </td>
                `;
                userTable.appendChild(row);

            });
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });
}

// Update admin profile
function updateAdminProfile(event) {
    event.preventDefault(); // Prevent the default form submission

    // Get form values
    const fullName = document.getElementById('adminName').value;
    const email = document.getElementById('adminEmail').value;
    const phone = document.getElementById('adminPhone').value;
    const address = document.getElementById('adminAddress').value;
    password = document.getElementById('adminPassword').value;

    // Create the data object
    const userProfileData = {
        userProfileID: profileID,
        name: fullName,
        email: email,
        address: address,
        phone: phone,
        picture: base64String,
        password: password
    };

    var apiUrl = '/api/admindashboard/update'

    // Make the API call to update the user profile
    fetch(apiUrl, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(userProfileData)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Error updating user profile');
            }
        })
        .then(data => {
            console.log('Profile updated successfully:', data);
            alert('Profile update successful!');
        })
        .catch(error => {
            console.error('Error:', error);
            alert('There was an error updating the profile.');
        });
}

// Search for users
function searchUsers() {
    const searchUser = document.getElementById('userSearch').value;

    if (searchUser == null || searchUser == "") {
        alert('Please enter a user to search.');
        return;
    }

    var apiUrl = '/api/userdashboard/' + searchUser;

    fetch(apiUrl)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json(); // Expect JSON data
        })

        .then(data => {
            userTable.innerHTML = ''; // Clear existing rows

            const row = document.createElement('tr');
            console.log(data.accountNo);
            row.innerHTML = `
                <td>${data.name}</td>
                <td>${data.email}</td>
                <td>${data.phone}</td>
                <td>${data.accountNo}</td>
                <td>
                    <button type="button" onclick="editUser('${userProfile.name}')"> Edit </button>
                    <button type="button" onclick="deactivateUserProfile(${parseInt(data.profileID)})"> Deactivate </button>
                    <button type ="button" onclick="resetUserPassword(${parseInt(data.profileID)})"> Reset Password </button>
                </td>
            `;
            userTable.appendChild(row);
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });
}

// Edit user profile
function editUser(name) {
    document.getElementById('userEditSection').style.display = "block";
    editName = name;
    console.log("Currently Editing: ", name);

    setCurrentEditingUser(); // Insert existing values for current editing user

}

// Edit profile
function editProfile(event) {
    event.preventDefault();
    // Get form values
    const fullName = document.getElementById('editName').value;
    const email = document.getElementById('editEmail').value;
    const phone = document.getElementById('editPhone').value;
    const address = document.getElementById('editAddress').value;

    // Create the data object
    const userProfileData = {
        userProfileID: editProfileID,
        name: fullName,
        email: email,
        address: address,
        phone: phone,
        picture: base64String,
        password: editPassword
    };

    console.log(userProfileData);

    //var apiUrl = '/api/userdashboard/update';
    const apiUrl = `/api/userdashboard/update?originalName=${encodeURIComponent(editName)}`;

    // Make the API call to update the user profile
    fetch(apiUrl, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(userProfileData)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Error updating user profile');
            }
        })
        .then(data => {
            console.log('Profile updated successfully:', data);
            alert('Profile update successful!');
            updateUserList();
        })
        .catch(error => {
            console.error('Error:', error);
            alert('There was an error updating the profile.');
        });
}

// Set the current editing user
function setCurrentEditingUser() {
    console.log("Setting up " + editName);
    var apiUrl = '/api/userdashboard/' + editName;
    fetch(apiUrl)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json(); // Expect JSON data
        })
        .then(data => {
            editProfileID = data.profileID;
            editPassword = data.password;
            document.getElementById('editName').value = data.name;
            document.getElementById('editEmail').value = data.email;
            document.getElementById('editPhone').value = data.phone;
            document.getElementById('editAddress').value = data.address;
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });
}

// Close the edit user section
function closeEditUser() {
    document.getElementById('userEditSection').style.display = "none";
}

// Create new account
function createNewAccount(event) {
    event.preventDefault();

    var apiUrl = '/api/admindashboard';

    const newName = document.getElementById('newFullName').value;
    const newEmail = document.getElementById('newEmail').value;
    const newPhone = document.getElementById('newPhone').value;
    const newAddress = document.getElementById('newAddress').value;
    const newPassword = document.getElementById('newPassword').value;

    const newUserProfile = {
        userProfileID: 0,
        name: newName,
        email: newEmail,
        phone: newPhone,
        address: newAddress,
        password: newPassword,
        picture: ""
    };

    console.log("New Profile: ", newUserProfile);
    fetch(apiUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(newUserProfile)
    })
        .then(response => {
            if (!response.ok) {
                console.log('Error creating account');
                return response.text().then(text => {
                    throw new Error(text); // Use response text as the error message
                });
            }
        })
        .then(data => {
            console.log('Account created successfully:', data);
            alert('Account creation successful!');
            updateUserList();
        })
        .catch(error => {
            console.error('Error:', error);
            alert(`Error: ${error.message}`);
        });
}

// Search transactions
function searchTransactions() {
    //get form values
    const transactionSearch = document.getElementById('transactionSearch').value;

    if (transactionSearch == null || transactionSearch == "") {
        alert('Please enter a user to find transactions of.');
        return;
    }

    var apiUrl = '/api/userdashboard/' + transactionSearch;
    console.log("Getting Transaction Details for " + transactionSearch);

    fetch(apiUrl)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json(); // Expect JSON data
        })
        .then(data => {
            // Populate the table with transaction data
            transactionHistory.innerHTML = ''; // Clear existing rows
            data.transactionsList.forEach(transaction => {
                const row = document.createElement('tr');
                row.innerHTML = `
                    <td>${data.name}</td>
                    <td>${data.accountNo}</td>
                    <td>${transaction.transactionDate}</td>
                    <td>$ ${transaction.amount}</td>
                    <td>${transaction.transactionType}</td>
                `;
                transactionHistory.appendChild(row);
            });
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });
}