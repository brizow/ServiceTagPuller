ServiceTagPuller
7/30/2016
Brett Wingard

Details:
This little C# app was used to quickly grab PC information for a documentation project I had.
I was able to leverage this to fill in the missing gaps that SpiceWorks was not able to.
The HTML tables are easy to read and copy in to an Excel or Google Sheet.

How To Use:
Enter network level admin credentials to pull data. If you are on the same domain as the 
computers you are looking for, no need to supply domain switch. Check a box for the data you want
to return. Wait, look at results.

Enhancements to think about.

-Ping Machine prior to CMD call to see if it is up.
-Pull mulitple machines to a grid style view.
-Refactor the code, seems a bit messy. I'm making multiple calls to the same method.
-Proper overlay instead of not responding. 
  -If you are waiting for results, this generally happens for PCs across a tunnel the app will go not responding if you are click happy.
-Dump data in to a database directly. 
