## Behavioral Design Patterns

### Template Method Pattern

#### Problem
Repeated workflows across multiple classes with small variations lead to duplicated code and inconsistent execution order.

#### Solution
Define the algorithm structure once in a base class and let subclasses override only the variable steps.

#### Intent
Enforce a fixed process flow while allowing controlled customization of specific steps.

#### Drawbacks
Relies on inheritance, increases coupling, and makes workflow changes expensive.

#### Use When
The workflow is stable, step order is critical, and business rules must not be altered by implementations.
