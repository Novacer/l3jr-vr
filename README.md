Ever stood outside arguing about what to eat? Overwhelmed by the choices? hEAT Vision allows you to see ratings, pricing, and recommends you the best places in an engaging VR environment.

## Inspiration
We were inspired by the capabilities provided by the Facebook Places API. With just your location it can recommend a bunch of very cool places around you. However, we wanted a novel and innovative way to organize the information in a way that makes it easy for you to make access it and make decisions.

## What it does
It is a Google Cardboard VR app that pulls data about the nearest restaurants around you - ratings, prices etc, and displays them in a virtual menu. You can explore around the street view like environment and see which the ratings of each restaurant. It also highlights a recommended restaurant near you.

## How we built it
We started by pulling data from the Facebook Places API into a Firebase database. We also processed and formatted the data at this step so it was easy for the client to consume. Then we implemented a Unity Cardboard VR game for Android. This VR client pulls data from the Flask backend to get the restaurants. We also calculated the angles and distance from the player to the restaurants so we can correctly place the marker. Further, we used raycasting to determine whether the player was looking at the restaurant or not. If the player looks at the marker for the restaurant, they can open a menu which will show them the relevant information. 

## Challenges we ran into
- Hard to deploy Google cloud functions
- Setting up unity for the first time
- Learning C# for the first time
- Figuring out what data can be accessed from Facebook API
- Camera movements in VR.
- External IP address can be static/ephemeral, and if its ephemeral then can't connect from outside

## Accomplishments that we're proud of
- Creating first VR app
- Animations
- Aggregating data from Facebook Places and organizing them
- Learning Flask

## What we learned
- How to Unity
- How to use flask
- GCP network

## What's next for l3jr-vr
-AR
-Dynamic locations
