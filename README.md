This project contains the solution for the Note application problem given by Intuit.
The entire code was done within five days hence only part of the problem was implemented, however the design caters to all the requirements mentioned in the problem statement.

Please refer to architecture presentation for more details.

Problems: 

Build a desktop note taking application (like Evernote/OneNote, etc.)

A note is comprised of a title and a body of text.
Users can store multiple notes.
Users can select a note for editing. The title and the body can be edited.
Copies of notes are stored on the cloud as well, so that they can be edited by web versions of the application.
Changes that were made on the cloud are also synced back to the desktop application.
The desktop application can work offline. As a result, the changes made to notes on the cloud and desktop are synced when it is back online.
In the case of a conflict when the same note is modified both online and offline, the desktop copy of the note is retained and the copy of the note on the cloud is discarded and replaced with the desktop copy.
When notes are being synced, user experience must not be hampered by blocking user's interaction with the app.
Also, users value the ability to open a note and start editing it immediately. So, syncing a note during open will not result in a good user experience.
A note can be also be shared over email, using the default mail client on the desktop.

The scope of the case study is limited to building the desktop application.
While the web application is outside the scope of this exercise, there should be a means to simulate changes made to the cloud copy of the notes, so that the sync can be validated.
Please feel free to use any Microsoft technology to build the app.
HTTP must be used for communication between the desktop and the cloud.
The use of automated unit/integration tests and suitable mocks/stubs is highly encouraged.

Apart from a working prototype, please be ready to discuss the design (design patterns, classes, interfaces, etc.) of the application and its testability.


