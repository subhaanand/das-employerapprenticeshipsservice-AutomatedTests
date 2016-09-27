# das-employerapprenticeshipsservice-AutomatedTests
This is a regression suite for Automated browser acceptance tests
Built on Specflow and Selenium using C# for plumbing 

1.)In order to allow the projects find the browser drivers, the solution should be saved on the C drive in a folder named "code"
alternatively, make changes to the App.config file changing the paths of the browser drivers to the appropriate location.

2.)There is need to supply custom values for the below keys held in the configuration file:

"PireanUsername" value=""
"PireanPassword" value=""
"InvitedUserName" value=""
"InvitedUserPW" value=""
"CompanyNumber" value=""
"CompanyName" value=""
"HMRCUN" value=""
"HMRCPW" value=""
3.) Feature files require example values in a number of places to allow the tests to run.
