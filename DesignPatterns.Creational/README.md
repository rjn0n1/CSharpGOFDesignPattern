# Creational Design Patterns

Creational design patterns focus on **how objects are created**, rather than
how they are used or structured. They abstract the instantiation process,
making systems more flexible, reusable, and easier to maintain.

## Patterns Covered
- Singleton
- Factory Method
- Abstract Factory
- Builder
- Prototype

## Key Problems They Solve
- Controlling object creation
- Decoupling client code from concrete implementations
- Managing complex construction logic
- Ensuring consistent object lifecycle management

## When to Use Creational Patterns
- When object creation logic is complex or error-prone
- When the system should be independent of how objects are instantiated
- When different implementations may be required at runtime
- When controlling the number of instances is critical

## Notes
Each pattern is implemented in isolation with:
- Clear intent
- Minimal, focused code
- Emphasis on design trade-offs rather than framework usage

## Singleton Pattern

### Variants
- Lazy Singleton (not thread-safe)
- Thread-safe Singleton using locking
- Thread-safe Lazy<T> (recommended)

## Factory Method Pattern
 
 Defer instantiation to subclass, interface,
### Description
 

### Structure
 1. Product: Interface/Abstract
	1. Concrete Product: Implementation of the Prodcxt
	1. 

### Implementation

### Use Cases
	Discount: Freedom Sale, Deepawali Sale 
	Exporting documents to different formats
	Instantiating plugins in plugin system
	Generating mocks or test data
	Abstracting data sources

### Pattern Consequences



## Prototype Pattern

 
### Description
 Prototype Pattern creates new objects by cloning existing ones instead of constructing them from scratch.

### Structure
 1. Product: Interface/Abstract
	1. Concrete Product: Implementation of the Prodcxt
	1. 

### Implementation

### Use Cases
	1. HIS / Healthcare (your domain)

		Base ClaimRequest

		Clone per patient

		Modify patient-specific fields

		Avoid rebuilding FHIR-heavy objects

	2. Document templates

		Invoice template

		Discharge summary template

		Prescription template

		Clone → fill → send

	3. Game engines

		Enemy archetypes

		Weapon configs

		Skill trees

		Creation cost is huge → cloning is cheaper.

	4. Configuration snapshots

		Base config loaded once

		Clone per request / tenant

### Pattern Consequences

### Not Benefecial
   If creating an object is cheap → Prototype is useless.

	'''
	Objects are simple DTOs

	Constructors are cheap

	Object graph is small

	You don’t control mutation
	'''

