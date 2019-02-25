# Simple Master/View Application with Video Games 

Coding assignment by Newton.

## Requirements
The front-end requires Node/NPM to run the front-end server to serve the static HTML and AngularJS bundle. A compiled JS bundle is already committed, but if you'd like to run transpiling/bundling yourself, you would need to open a command prompt in the Front-End project and run "npm run build". No minification takes place.

The back-end is just a simple WebAPI IIS web server. You would need to configure the location of your SQL Server if neccessary, and run the migration.

My Visual Studio project is set to run multiple project mode on build (F5), so it will spawn both an IIS and Node server together.


## Challenges
I favored a modern front-end build configuration, rather than just linking JS files in the HTML page. It took a fair bit of time to set that up properly, especially with proper importing hierarchy.

Understanding AngularJS while conforming to the recommended style guide also caused a bit of confusion on my end.

There were no major challenges with the WebAPI side, other than configuration of the Entity Framework / Migrations. It is different than Laravel migrations.


## Missed / To Do
I didn't include Angular UI - Bootstrap. I just used Bootstrap directly in my template files.

As important as it sounds, I did not have validation yet on editing a video game item, nor warning/success messages.
