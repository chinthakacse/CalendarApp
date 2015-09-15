# CalendarApp
Calendar Application

This Solution contains 3 Projects.
1. Octet.CalendarApp.Api
2. Octet.CalendarApp.Web
3. Octet.CalendarApp.Model

- In addition to the API and Web Projects, Model Project was added to share the Models between the API and Web Project.
- Currently the CalenderItem has a Property for the Image Url which are stored in the Web Project. This is just for the 
sample Project. Practical solution would be to add a separate Project/Controller to server the images or serve binary 
through CalenderItem model. I haven't implemented that because of the time limitation i had.
- Actual UI may be different from the one I have developed since I did this on my own
- Environment and Technologies
   a. Visual Studio 2013 as the IDE
   b. Started the solution with Scaffolded Projects for Web api and MVC Web Application
   c. Technologies are ASP.NET MVC, Web API, Bootstrap, HTTPClient for calling the Web API and Newtonsoft.JSON for deserializing
      JSON Objects.
- I haven't added any DB or ORM Framework, but returned a hardcoded set of Calendars from API

