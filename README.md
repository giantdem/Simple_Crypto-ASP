# Simple Crypto
Simple encryption web application (ASP.NET &amp; AngularJS)

------------


**BUILD on Somee**: http://giantdem.somee.com/


------------

This web-based application is a simple encryption tool that replaces the Cyrillic letters with other ones from the same alphabet.

![](https://github.com/giantdem/Simple_Crypto-ASP/blob/master/RM_screenshots/RM_screenshot1.jpg?raw=true)

**GUI consists of**: input field, submit button, waiting badge, error alert, and output log table.

The server accesses the database during the encryption process.
There are several tables in the database.

**CryptoChars table**:

oldSymbol | newSymbol
--- | ---
а | т
б | ш
в | ь

**InputLog table**:

id | message | time
--- | --- | ---
1 | ffааА4 | 23-Sep-19 12:40:20 AM
2 | пвпавпавр54уе3п | 23-Sep-19 12:40:50 AM
3 | ЪУЪ | 23-Sep-19 12:42:38 AM

*\* DB connection string is protected on a local dev machine.*
