# .NET Standard Review Body

We need a .NET Standard review body. We make the following proposal:

  * **.NET Team**. The rationale here is that most, if not all, of the APIs
    that are part of .NET Standard are implemented and evolved by the .NET team.
  * **Xamarin**. They are a platform vendor and have their own implementation.
    While they mostly copy our code, changes and extensions can impact their
    ability to support .NET Standard. Thus, we need to coordinate any changes
    with them.
  * **Unity**. Same rationale as for Xamarin.

Please note that this list isn't meant to be closed: as more platform vendors
and API drivers appear, the review board will expand accordingly.
