
# Assignments Overview

This repository contains four different assignments based on various software design patterns. Each assignment represents a unique scenario that requires a solution designed for extensibility, modularity, and clean architecture. Below is the description of each assignment, with hints and the design strategy for future extensibility in mind.

---

## Assignment 1: Payment Methods

### Scenario
You're developing a payment system for an online store. The system needs to support multiple payment options, such as:

- **CreditCardPayment**
- **BankTransfer**
- **PayPal**

Each payment option has its own way of processing payments. The system should allow users to choose their preferred payment method during checkout and process the payment accordingly. The design must be flexible enough to allow for adding new payment methods without modifying the existing codebase.

### Solution Strategy
- Use the **Strategy Pattern** to encapsulate the different payment methods.
- Define an interface `IPaymentMethod` with a method `ProcessPayment()`.
- Each payment method (CreditCard, BankTransfer, PayPal) will implement this interface.
- The main checkout system will handle payments uniformly, regardless of the specific payment method chosen.

### Hint
Ensure that adding new payment methods in the future is easy without changing the core code.

---

## Assignment 2: Vehicle Control System

### Scenario
A company is developing software for different types of vehicles. The application needs to handle various vehicle types such as:

- **Car**
- **Truck**
- **Motorcycle**

Each vehicle must be able to:

- **Start** and **Stop** the engine.
- Describe itself in a unique way (e.g., Car describes itself differently than Truck).

The system should allow all vehicle types to be controlled similarly (for example, starting or stopping) while maintaining unique behaviors for each vehicle.

### Solution Strategy
- Use **Inheritance and Polymorphism**.
- Create a base class `Vehicle` with methods like `Start()`, `Stop()`, and a virtual `Describe()` method.
- Each vehicle type (Car, Truck, Motorcycle) will inherit from `Vehicle` and override the `Describe()` method to provide specific behavior.

### Hint
Design the solution to control all vehicle types similarly while allowing each to have its own specific behavior.

---

## Assignment 3: Media Player Plugins

### Scenario
You're developing a media player application that needs to support different types of media:

- **Audio**
- **Video**

Each media type must have `Play()` and `Stop()` functions, but the implementation of these functions will vary for each type. In the future, new media types might be added, such as:

- **Podcast**
- **LiveStream**

### Solution Strategy
- Use the **Strategy Pattern** or **Interfaces**.
- Define a common interface `IMedia` with methods `Play()` and `Stop()`.
- Implement this interface for each media type (Audio, Video, Podcast, etc.).
- The media player will interact with the media types through the interface, making it easy to add new types later.

### Hint
Design the media player to interact with all media types uniformly, without knowing the specific details of each type.

---

## Assignment 4: Customer Notifications

### Scenario
Your application needs to notify customers in various ways:

- **Email**
- **SMS**
- **Push Notification**

Each notification method has its own way of sending messages. The system should be flexible enough to allow adding or replacing notification methods in the future without making major changes to the rest of the code.

### Solution Strategy
- Use the **Strategy Pattern**.
- Define a `INotificationStrategy` interface with a `Send()` method.
- Implement the interface for each notification type (Email, SMS, Push Notification).
- The application should send notifications uniformly by interacting with the interface, allowing new notification methods to be added easily.

### Hint
Design the notification system to handle all types of notifications uniformly while allowing different implementations.

---

## Key Design Patterns Used

1. **Strategy Pattern**: Encapsulates a family of algorithms (payment methods, media types, notifications) and makes them interchangeable. It allows the algorithm to vary independently from clients that use it.
2. **Polymorphism and Inheritance**: Used in the Vehicle Control System to provide a common interface for different vehicle types while allowing specific behaviors.
3. **Interface-Based Programming**: All systems are designed to use interfaces to ensure loose coupling and easy extensibility.

---

## How to Add New Functionality

For all assignments, adding new functionality is simple:

- **Payment Methods**: Implement the `IPaymentMethod` interface for the new payment type.
- **Vehicle Types**: Inherit from the `Vehicle` base class and override necessary methods.
- **Media Types**: Implement the `IMedia` interface for the new media type.
- **Notification Methods**: Implement the `INotificationStrategy` interface for the new notification method.

This design ensures that future extensions do not require modifying existing code, adhering to the **Open/Closed Principle**.

--- 

