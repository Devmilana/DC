
// Load user profile details 
function loadUserProfileDetails() {

    // Define the API URL with the current username
    var apiUrl = '/api/userdashboard/' + currentUsername;
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
            document.getElementById('fullName').value = data.name;
            document.getElementById('email').value = data.email;
            document.getElementById('phone').value = data.phone;
            document.getElementById('address').value = data.address;
            document.getElementById('password').value = password;

            if (data.picture) { // Display profile picture
                base64String = data.picture;
                const imageUrl = `data:image/png;base64,${base64String}`;
                document.getElementById('profilePicture').src = imageUrl; // Set image source
            }

            // Display account settings
            console.log("Loading Account Details");
            document.getElementById('accountNumber').textContent = data.accountNo;
            accountBalance = data.balance;
            document.getElementById('accountBalance').textContent = `$${accountBalance.toFixed(2) }`;

            console.log("Loading Transaction History")
            const transactionHistory = document.getElementById('transactionHistory');
            transactionHistory.innerHTML = ''; // Clear existing rows
            
            // Populate the table with transaction data
            data.transactionsList.forEach(transaction => {
                const row = document.createElement('tr');
                row.innerHTML = `
                    <td>${transaction.transactionDate}</td>
                    <td>${transaction.transactionType}</td>
                    <td>$${transaction.amount.toFixed(2)}</td>
                `;
                transactionHistory.appendChild(row);
            });
        })
        .catch(error => {
            console.error('Fetch error:', error);
        });
}

// Perform a transaction
function doTransactions(event) {
    event.preventDefault();

    // Get form values
    const recipientAccountID = document.getElementById('recipientAccount').value;
    const amount = parseFloat(document.getElementById('transferAmount').value);

    const transactionType = document.querySelector('input[name="transactionType"]:checked').value;

    if (isNaN(amount) || amount <= 0) {
        console.log('Invalid amount entered.');
        alert('Please enter a valid amount.');
        return;
    }

    if (transactionType === "Withdrawal" && profileID !== Number(recipientAccountID)) {
        console.log('Attempted withdrawal from a different account.');
        alert('You can only withdraw from your own account.');
        return;
    }

    console.log("Transaction initiated: Recipient AccountID = ${recipientAccountID}, Amount = ${amount}, Transaction Type = ${transactionType}");
    const transactionData = {
        transactionId: 0,
        accountId: recipientAccountID,
        amount: amount,
        transactionDate: new Date().toISOString(),
        transactionType: transactionType,
    };

    var apiUrl = '/api/userdashboard';

    // Make the API call to perform the transaction
    fetch(apiUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(transactionData)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Error processing the transaction');
            }
            return response.json();
        })
        .then(data => {
            console.log('Transaction completed successfully:', data);
            alert('Transaction successful!');

            //Update transaction history and account balance when necessary
            if (recipientAccountID == profileID) {
                const transactionHistory = document.getElementById('transactionHistory');
                const row = document.createElement('tr');
                row.innerHTML = `
                    <td>${transactionData.transactionDate}</td>
                    <td>${transactionType}</td>
                    <td>$${amount.toFixed(2)}</td>
                `;
                transactionHistory.appendChild(row);

                if (transactionType === "Deposit") {
                    accountBalance += amount;
                }
                else {
                    accountBalance -= amount;
                }
                document.getElementById('accountBalance').textContent = `$${accountBalance.toFixed(2)}`;
            }
        })
        .catch(error => {
            console.error('Error:', error);
            alert('There was an error processing the transaction.');
        });
}

// Update user profile
function updateUserProfile(event) {
    event.preventDefault(); // Prevent the default form submission

    // Get form values
    const fullName = document.getElementById('fullName').value;
    const email = document.getElementById('email').value;
    const phone = document.getElementById('phone').value;
    const address = document.getElementById('address').value;
    password = document.getElementById('password').value;

    console.log(profileID);
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