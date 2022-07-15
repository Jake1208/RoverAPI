# RoverAPI
This Web API App is designed to retrieve images from NASA's Perseverance, Curiosity, Oppportunity and Spirit Rovers by the Sol Date that they were taken.

# API Key
The included endpoint uses NASA's DEMO_KEY API key and should not require any input from the user.

# Photo Attributes
When retrieving the data from the API the user can expect to see data that contains the URL to access and view the images, as well as data on the Rover that took the image, the Camera on the rover responsible for it and the Earth date that corresponds with the Sol date being Queried.

If a Sol Date is entered that doesn't match any records in the database, a 404 Not Found error will be triggered.

# Executing a Query
After cloning the repo to a new folder on your local machine, you can run the App inside Visual Studio. This will launch a Swagger UI on a LocalHost port inside your default web browser. Here you will see an interface that allows you to execute the Get Request and retrieve the Images and related data for the Sol Date entered into the solDate form field. to enter a number into the field, simply click the Try it out button towards to top right side of the screen. Aftrer doing so, the solDate field can be typed inside of. Once a number has been entered, clicking the Execute button will send the request and the response body will be visible directly below. Users should note that the solDate field is set to receive an Integer and will not execute if any other characters have been entered.
