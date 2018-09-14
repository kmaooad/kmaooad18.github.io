# Course Home
#### Main repo of the course with curriculum and materials

## Discussions and questions

There is a chat on Gitter, click [![Join the chat at https://gitter.im/kmaooad18/course-home](https://badges.gitter.im/kmaooad18/course-home.svg)](https://gitter.im/kmaooad18/course-home?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) to join. There are several channels there. This repo channel (course-home) is for discussing lectures, theoretical issues, general ideas on topic (OOAD), and for _important_ organizational announcements. Please, ask common questions in this public channel, not in personal chat, so that everyone could benefit from the discussion. Also, for assignment-specific discussions, use their own channels (gitter button is in every assignment repo). Don't ask assignment questions in general channel.

## Assignments

Every week assignment deadline is 01:00 AM on next Monday (_after_ next week!)

[Demo assignment](https://classroom.github.com/a/Y6I_OfSu) (Deadline 23/09)

[Week 2 (Rubik's Cube)](https://classroom.github.com/a/pqvBgp3I) (Deadline 23/09)

### Accessing assignment

1. Create your personal GitHub account (if you don't have one)
2. Login to GitHub and follow one of the assigment links above
3. On your first opening some assignment, GitHub will request access from Classroom to your account - that's totally ok, just grant access.
4. As you accept the assignment, GitHub will create your personal private repository and put starter code for assignment there. YOur repository will be named like 'assignment-w4-yournickname' etc.
5. Further use your personal repository from the previous step to complete and submit assignment.

### Implementing assignment

1. Assigments are implemented with .NET Core 2.1 or later. 
2. To be able to develop, build, and run assignments you will need to install [.NET Core 2.1 SDK](https://www.microsoft.com/net/download/dotnet-core/2.1). (You are not limited to Windows since .NET Core is a cross-platform framework)
3. You are free to use any editor you like or even go pure command-line, but the recommended IDE is [Visual Studio Code](https://code.visualstudio.com/download) (it's also cross-platform, it's nice, lightweight, simple, yet powerful). There is also a [portable version](https://code.visualstudio.com/docs/editor/portable) that does not need installation.
4. To build the assignment, clone your repository from GitHub, in VS Code terminal or plain command line go to project folder (you need one with .csproj file in it), and execute `dotnet build`, or you may use `dotnet run` to build and run at once.
5. Assignment comes as a starter code, typically one or more main code files (.cs) and Spec.cs file with specification tests.
6. You need to fill main code file(s) with your implementation so that the program does what's expected. Start code in main files provides classes stubs, method stubs etc. You need to implement provided methods and/or add more of your own, if necessary.
7. A good sign of properly implemented program (in terms of spec) is successful run of tests from Spec.cs. To check those, execute `dotnet test` or `dotnet xunit`. You'll see if some requirements do not hold - test(s) will fail.
8. Don't try to cheat the tests: there are more on the teacher's side to make sure your implementation is the _real_ one, not just the tests-cheater :)
9. Commit and push your progress to GitHub regularly: local PC crash sometimes. Make sure you commit and push your work in advance before the deadline. Last commit _before_ the deadline will be taken for assessment.


## Resources

TBD
