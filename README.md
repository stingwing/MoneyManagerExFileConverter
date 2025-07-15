I've been using the Money Manager Ex https://moneymanagerex.org/ program but was unable to get the catagories and payees to work how I wanted.
This program takes CSV files from ING bank transaction history and gives the user the option to add a payee based on a search string.
All in c#

To do.
Work out how money manager ex importer handles catagores (i noticed it had a field for that later) and impliment a new column based on that.
Work out why the uidata table is lagging.
Improve the search string logic.
Add more error handling.
Refactor the code to make it less cancer.
Clean up the work flow its a bit convluted at the moment.
Look into adding a sqlite or equivlant data base for holding settings/transaction history/key words
