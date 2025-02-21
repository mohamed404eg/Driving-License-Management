Project – Driving License Management:
This my project to Driving License Management in country ;

# Screenshot

![Screenshot](Media/Screenshot.png)

# noetic


## Applications Status
- Applications.ApplicationStatus = 1 THEN 'New'
- WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'
- WHEN Applications.ApplicationStatus = 3 THEN 'Completed'
- END AS Status



## Applications Type
- Replacement for a Lost Driving License = 1
- New Local Driving License Service = 2
- Renew Driving License Service = 3
- Replacement for a Damaged Driving License = 4
- Release Detained Driving Licsense = 5
- New International License = 6


# Main Features 
## create Applications
by Applications you can create withe Appointments or  InternationalLicenses or Local Licenses.
## TestAppointments
create TestAppointments to Take all Tetst in oreder to pass Test And Take Licenses
## Users and People
User is User work in Cmopany and administrator.
People is administrator User And Normal User Like driver.
# Image Size

- large x2 128px
- large 64px
- medium 32px
- small 24px


# IssueReason

- 1 License issuance service for the first time. Application fee is $5.
- 2 Re-inspection service. Application fee is $5.
- 3 Driving license renewal service. Application fee is $5.
- 4 Issuing a replacement for a lost license service. Application fee is $5.
- 5 Service for issuing a replacement for a damaged license. Application fee is $5.
- 6 Driving license cancellation service. Application fee is $5.
- 7 International license issuance service. Application fee is $5.

# Main features

##    Applications: Replacement for Damaged or Lost Licenses 
![Screenshot](Media/Screenshot/Main%20features/Applications%20Replacement%20for%20Damaged%20or%20Lost%20Licenses/Applications%20Replacement%20for%20Damaged%20or%20Lost%20Licenses.png)
- Flow chart => https://whimsical.com/applications-replacement-for-damaged-or-lost-licenses-48AfgRiDmYSdKnKKwf9hTJ



# how running the project
## project
- Download the visual studio 22 community 
- then clone the project and open file name "DVLD - WindowsFormsApp.sln" 
- you need to add the database info before you running the programming
- add your database info in file name "clsConnectionsString.cs" in sub project "DVLD - DataAccess"
- and now you can run the applications

## database 
- you need to download the sqlserver and sql server management studio 
- after download import the database backup name "DVLD-v1.bak" in folder "DatabaseBackup" 
- now yuor finish .

