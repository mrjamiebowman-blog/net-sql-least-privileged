# Offensive .NET: Least Privileged (Entity Framework vs Stored Procedures)
This tutorial will demonstrate the possible risk and missconfigurations associated with using Entity Framework vs using T-SQL Stored Procedures. I'll demonstrate how Stored Procedures can be more secure than using Entity Framework. It's important to note that this is based on typical useage of Entity Framework. The blog post and video will demonstrate how a hacker could compromise a container and what they could do once they are in.  

I'll be deomnstrating the exploitation using Parrot Security OS and Burp Suite Pro.  

## Vulnerabilities
The initial foot hold will be through the use of Local File Inclusion (LFI) vulnerability and a Remote Code Execution (RCE) vulnerability. I will demonstrate some awful practices and things developers should never do. This is not likely or normal but it's possible and has certainly happened in the past. Developers who are completely unaware of this could easily make this mistake. I certainly have done it myself early on in my career when I started off with PHP. This is all in theory and certainly could happen through a variety of means whether it's malicious 3rd party libraries on NuGet, SQL injection, lateral moves from other compromised containers, and/or if the entire cluster has been compromised.

From there, we will aquire the SQL Server credentials and see what kind of malicious things we can do.  

#### Vulnerabilities & Missconfiguraitons

* Local File Inclusion (LFI)
* Remote Code Execution (RCE)
* Remote Access to SQL Server Enabled
* Running Container under Root

### Entity Framework
Being that Entity Framework typically does CRUD operations and has the ability to view and manipulate tables (migration scripts) this will allow us the most capabilities to access, extract, and manipulate data.

### Stored Procedures (Dapper)
Using Stored Procedures we will create a user that ONLY has execute permissions to the database. The stored procedure will also be designed around a multi-tiered database. The hacker will still be able to get data and manipulate data it will just be significantly more difficult. We will use the Dapper library to interface the stored procedures.