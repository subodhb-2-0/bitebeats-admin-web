
import { initializeApp } from "https://www.gstatic.com/firebasejs/10.8.1/firebase-app.js    ";
 //import {getAuth} from "https://www.gstatic.com/firebasejs/10.8.1/firebase-auth.js";

let firebaseLoaded = false;
// window.onload = async function () {
// Your web app's Firebase configuration
const firebaseConfig = {
    apiKey: "AIzaSyDU9Sewj0vd14rqcz2FwoKFBtg0Ks5zxGQ",
authDomain: "learn-jwt-4bb9c.firebaseapp.com",
projectId: "learn-jwt-4bb9c",
storageBucket: "learn-jwt-4bb9c.appspot.com",
messagingSenderId: "920023854999",
appId: "1:920023854999:web:844f6a6c05960c23771ed2",
measurementId: "G-LT8ZEMSVHQ"
};
console.log(firebase);
// Initialize Firebase
const app = initializeApp(firebaseConfig);
firebase.initializeApp(firebaseConfig);

const ui = new firebaseui.auth.AuthUI(firebase.auth());
const auth = firebase.auth();
const uiConfig = {
    callbacks: {
    signInSuccessWithAuthResult: function (authResult, redirectUrl) {
        // Access the user object
        const user = authResult.user;
        firebaseLoaded = true;

        // Get the UID
        const uid = user.uid;
        console.log(`User UID: ${uid}`);

        // Get the user's token
        // console.log(user.stsTokenManager.accessToken);
        user.getIdToken().then(function (accessToken) {
            console.log(access)
        });

        // Save authResult (if needed)
        localStorage.setItem("firebaseResult", JSON.stringify(authResult));

        window.location.href = redirectUrl;
        return true;
    },
    uiShown: function () {
        document.getElementById('loader').style.display = 'none';
            }
        },
    signInFlow: 'popup',
    signInSuccessUrl: '/restaurant',
    signInOptions: [
    // Add authentication providers here
    firebase.auth.GoogleAuthProvider.PROVIDER_ID,
    {
        provider: firebase.auth.EmailAuthProvider.PROVIDER_ID,
        requireDisplayName: false
    },
    {
        provider: firebase.auth.PhoneAuthProvider.PROVIDER_ID,
        recaptchaParameters: {
            type: 'image', // 'audio'
            size: 'normal', // 'invisible' or 'compact'
            badge: 'bottomleft' //' bottomright' or 'inline' applies to invisible.
        },
        defaultCountry: 'NP'

    }
    ]
};

ui.start('#firebaseui-auth-container', uiConfig);

window.initApp = function () {
    firebase.auth().onAuthStateChanged(function (user) {
        if (user) {
            document.getElementById('signInStatus').textContent = 'Sign In Successfully';
            checkTokenExpiry();
            // User is signed in.
            var displayName = user.displayName;
            var email = user.email;
            var emailVerified = user.emailVerified;
            var photoURL = user.photoURL;
            var uid = user.uid;
            var phoneNumber = user.phoneNumber;
            var providerData = user.providerData;
            user.getIdToken().then(function (accessToken) {
                //var accountDetails = document.getElementById('accessToken');
                // HTML content to append (including HTML tags)
                //var newHTML = '<p>'+ accessToken +'</p>';
                console.log(accessToken);
                // Append the new HTML content to the element
                //accountDetails.innerHTML += newHTML;
                //document.getElementById('account-details').textContent =
                //   console.log(JSON.stringify({
                //    displayName: displayName,
                //    email: email,
                //    emailVerified: emailVerified,
                //    phoneNumber: phoneNumber,
                //    photoURL: photoURL,
                //    uid: uid,
                //    accessToken: accessToken,
                //    providerData: providerData
                //}, null, '  '));

            });

        } else {
            document.getElementById('signInStatus').textContent = 'Sign Out Successfully';
        }
    }, function (error) {
        console.log(error);
    });
};
window.refreshFirebaseToken = function () {
    var user = firebase.auth().currentUser;
    if (user) {
        firebase.auth().currentUser.getIdToken(/* forceRefresh */ true).then(function (token) {
            // Use refreshed token for Firebase requests
            console.log("Token refreshed:", token);
        }).catch(function (error) {
            console.error("Error refreshing token:", error);
        });
    }
}
window.checkTokenExpiry = function() {
    var user = firebase.auth().currentUser;
    if (user) {
        user.getIdTokenResult().then(function (idTokenResult) {
            var now = new Date().getTime();
            var expirationTime = new Date(idTokenResult.expirationTime);
            if (expirationTime < now) {
                refreshFirebaseToken();
            }
        }).catch(function (error) {
            console.error("Error getting ID token result:", error);
        });
    }
}

function signOut() {
    auth.signOut().then(function () {
        // Sign-out successful.
        console.log("User signed out successfully.");
    }).catch(function (error) {
        // An error happened.
        console.error("Error signing out:", error);
    });
}

// Example usage: Call the signOut function when a sign-out button is clicked
//document.getElementById('sign-out-button').addEventListener('click', function () {
//    signOut();
//});
document.getElementById('logout').addEventListener('click', function () {
    signOut();
});
window.addEventListener('load', function () {
        initApp()
});
