# TestFlight4Unity

## Introduction

The TestFlight SDK allows you to track how beta testers are testing your application. This repository offers Unity3d Objective-C bindings for TestFlight.

## Integration

- Copy all files to Assets/Scripts/Plugins/iOS in your Unity project.
- Copy the TestFlight SDK files from [testflightapp.com][1] to Assets/Scripts/Plugins/iOS.
- Get your App Token from [testflightapp.com][1]
- Set your App Token during the Awake event of a GameObject on your starting scene.
    - See TestFlightManager as an example of how to do this.

[1]: http://testflightapp.com
