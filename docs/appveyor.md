# Appveyor

We use a tool called Appveyor to help with our system builds. 
Once again, to get access either Erik, Kirk, or Kal needs to give you access to the Appveyor project.

Appveyor is a tool that will attempt to build every single commit that is pushed to the Github project. If the build fails, then it will notify you.
Appveyor will also attempt to run the automated tests for the project.

Essentially, Appveyor helps catch issues from branch merges before you attempt to build the application yourself.

We use Appveyor as an assistant for our integration process because it will help save time and also give a record of what changes tend to break the build process.
Additionally, we can use it to verify that merges won't break our baseline.  

Currently, we don't have Appveyor produce any build artifacts, but in the future we could enable Appveyor to produce our final production application at the click of a button.
