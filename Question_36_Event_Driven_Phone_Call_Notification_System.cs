/*
Question 36
Event Driven Phone Call Notification System

Description
Question Description
A telecom company is developing a call notification module for its mobile application.
Users can subscribe or unsubscribe from phone call alerts.
The system must be designed using event-driven programming so that different components can react when the subscription status changes.

To ensure scalability and loose coupling, the company has decided to use Delegates and Events in C#.

Problem Statement

Design and implement a class named PhoneCall that uses delegates and events to notify when a user subscribes to or unsubscribes from phone call notifications.

Technical Requirements

1. Delegate Definition

Define a delegate named:

Notify

Represents a method with no parameters and no return type.
2. Event Declaration

Declare an event:

PhoneCallEvent

Based on the Notify delegate
Responsible for notifying subscribers about subscription changes
3. Message Property

Implement a property:

string Message { get; private set; }

Stores the current notification status
Should not be modified directly outside the class
4. Event Handlers

Implement two private methods:

Method Name

Responsibility

OnSubscribe()

Updates the message to "Subscribed to Call"

OnUnSubscribe()

Updates the message to "UnSubscribed to Call"

5. Event Trigger Method

Implement a public method:

void MakeAPhoneCall(bool notify)

If notify == true:
Attach OnSubscribe to the event
If notify == false:
Attach OnUnSubscribe to the event
Invoke the event safely using null-conditional invocation
6. Driver Code

Create a test class to:

Instantiate the PhoneCall object
Trigger both subscribe and unsubscribe scenarios
Display the updated message after each action
Sample Execution

Input

MakeAPhoneCall(true);

MakeAPhoneCall(false);

Output

Subscribed to Call

UnSubscribed to Call

Constraints

Direct method calls to OnSubscribe() or OnUnSubscribe() are not allowed
Event invocation must follow best practices
Code must compile and run without runtime exceptions
Maintain proper access modifiers and encapsulation
*/

using System;
namespace SampleAssignment
{
    class PhoneCall
    {
        public delegate void Notify();
        public event Notify PhoneCallEvent;
        public string Message { get; private set; }

        public PhoneCall()
        {
            Message = string.Empty;
        }
        public PhoneCall(string yourMessage)
        {
            Message = yourMessage;
        }

        private void OnSubscribe()
        {
            Message = "Subscribed to Call";
        }

        private void OnUnSubscribe()
        {
            Message = "UnSubscribed to Call";
        }

        public void MakeAPhoneCall(bool notify)
        {
            PhoneCallEvent = null;

            if (notify)
            {
                PhoneCallEvent += OnSubscribe;
            }
            else
            {
                PhoneCallEvent += OnUnSubscribe;
            }

            PhoneCallEvent?.Invoke();
        }
    }

    class Test
    {
        public static void Main(string[] args)
        {
            var call = new PhoneCall();
            call.MakeAPhoneCall(true);
            Console.WriteLine($"{call.Message}");
            call.MakeAPhoneCall(false);
            Console.WriteLine($"{call.Message}");
        }
    }
}