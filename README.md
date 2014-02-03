Secure Password Generator Lite
=================


The Story
==================
The story behind this tool is rather simple. I used to work for A DoE contractor as a Systems Administrator.
I had to maintain thousands of linux nodes (via SSH keys) but I still needed root passwords for local conole
access. The law (not policy but an actual law) required that each server have it's own unique password that matched
some very specific requirements. We also had to change these passwords every 180 days. Instead of insecure methods
such as spreadsheets, or notepad files, I opted to create a tool. It takes two strings, and uses a password generation
formula to convert them into the same password each time. This way you can reliably recover any password.

Using The Tool
==================
The first string is the fully qualified domain name (FQDN) of the server. (ie: mysql0017.server.doe.gov)
The second string is a unique phrase (Seed Text) that you must keep secret. This string should always be the same.
The Seed Text string is the phrase that when combined with the FQDN produces a DoE compliant password.
It's the same password every time, so whoever knows the Seed String, can gain root on any server you use this on.
In 180 days just change the Seed Text, and update the password on all of the servers.

Why is it called "Lite"?
==================
This version of the tool is missing some features. The DoE one (which I eventually adapted an employer in the private
sector as well) had AD authentication built into it as well as a check-in with a server to make sure it was on site
on a DoE computer. (Server was not exposed to the web) The "Full version" also used a slightly different algorithm and contained
a third variable. I had to differentiate the two versions enough knowing one day I'd want to open source this.

What is a DoE compliant password?
==================
A DoE compliant password has a bunch of requirements:
1) Password contains at least eight non-blank characters, provided such passwords are allowed by the operating system or application.
2) Password contains a combination of letters (a mixture of upper and lowercase), numbers, and at least one special character within the
first seven positions, provided such passwords are allowed by the operating system or application.
3) Password contains a nonnumeric in the first and last position.
4) Password does not contain the user ID. (Note: My tool obviously cannot enforce this)
5) Password does not include the user’s own or, to the best of his/her knowledge, close friends or
relatives names, employee serial number, Social Security number, birth date, phone number, or any
information about him/her that the user believes could be readily learned or guessed. (Note: My tool obviously cannot enforce this either)
6) Password does not, to the best of the user’s knowledge, include common words that would be in an English dictionary, or from another
language with which the user has familiarity.
7) Password does not, to the best of the user’s knowledge, employ commonly used proper names, including the name of any
fictional character or place. (Sorry no Dalek themed passwords)
8) Password does not contain any simple pattern of letters or numbers, such as “qwertyxx” or “xyz123xx.”
9) Password employed by the user on his/her unclassified systems is different than the passwords employed
on his/her classified systems. (Up to you to enforce)

Yup that's a lot of requirements. DoE is in charge of nuclear research though, and I've never had an issue
remembering the few passwords I used daily, so it's not too bad.

Why are you open sourcing this?
==================
I felt that this tool was super handy both during and after my time at DoE. I adapted it to my next employer
and now I want to release a version that anyone can use, and that I can use without having to adapt it
each time. Also this is a great way to learn git and GitHub :P
