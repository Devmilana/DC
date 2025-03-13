
var currentUsername = "";
var password = "";
var base64String = "";
var accountBalance = 0;
var profileID = 0;

// Handle login
function handleLogin(status) {
    if (status === "userview") {
        currentUsername = document.getElementById('userUsername').value;
        password = document.getElementById('userPassword').value;
    } else if (status === "adminview") {
        currentUsername = document.getElementById('adminUsername').value;
        password = document.getElementById('adminPassword').value;
    }

    performAuth(status);
}

function performAuth(status) {
    const user = {
        userName: currentUsername,
        passWord: password
    };
    
    var apiUrl = null;

    
    if (status === "userview") {
        apiUrl = '/api/login/userauth';
    } else if (status === "adminview") {
        apiUrl = '/api/login/adminauth';
    }

    fetch(apiUrl, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(user)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Error logging user in');
            }
            return response.json();
        })
        .then(data => {
            const jsonObject = data;
            if (jsonObject.login) {
                console.log('Login successful!');
                alert('Login successful!');
                loadView(status);  // Load the user/admin view based on the status
            }
            else {
                console.log('Invalid Credentials!');
                alert('Invalid Credentials!');
            }
        })
        .catch(error => {
            console.error('Error:', error);
            alert('There was an error logging in.');
        });
}

// Function to load view based on the status
function loadView(status) {
    var apiUrl = null;
    if (status === "userview") {
        apiUrl = '/api/login/userview';
    }

    if (status === "adminview") {
        apiUrl = '/api/login/adminview';
    }

    if (status === "logout") {
        apiUrl = '/api/logout/logout';
    }

    console.log("Current view: ", status);
    fetch(apiUrl)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.text();
        })
        .then(data => {
            document.getElementById('main').innerHTML = data;

            if (status === "userview") {
                loadUserProfileDetails(); // Fetch and display profile details after loading the view
            }
            else if (status === 'adminview') {
                loadAdminProfileDetails();
            }

        })
        .catch(error => {
            // Handle any errors that occurred during the fetch
            console.error('Fetch error:', error);
        });
}

// Filter transactions based on date
function filterTransactions(index) {
    const startDate = document.getElementById('startDate').value;
    const endDate = document.getElementById('endDate').value;

    const transactions = document.getElementById('transactionHistory').getElementsByTagName('tr');

    if (!startDate || !endDate) {
        alert('Select both a start date and an end date.');
    }
    else if (startDate > endDate) {
        alert('Invalid start and end dates');
    }
    else {
        for (let i = 0; i < transactions.length; i++) {
            const transactionDate = transactions[i].getElementsByTagName('td')[index].innerText;
            if (transactionDate >= startDate && transactionDate <= endDate) {
                transactions[i].style.display = '';
            } else {
                transactions[i].style.display = 'none';
            }
        }
    }
}

// Function to switch between tabs
function showTab(tab) {

    document.getElementById('userTab').classList.remove('active');
    document.getElementById('adminTab').classList.remove('active');

    document.getElementById('userLogin').classList.remove('active');
    document.getElementById('adminLogin').classList.remove('active');

    console.log("Hello " + tab);

    // Show selected tab and make its button active
    if (tab === 'user') {
        document.getElementById('userTab').classList.add('active');
        document.getElementById('userLogin').classList.add('active');
    } else {
        document.getElementById('adminTab').classList.add('active');
        document.getElementById('adminLogin').classList.add('active');
    }
}