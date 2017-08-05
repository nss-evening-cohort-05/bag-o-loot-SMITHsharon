# Bag o' Loot

### Project Description 

For this exericse, given boilerplate code. The application displays a command line prompt, reads user input, and then based on the input value, executes other code. 

- There is a `Child` object with two properties: `name` and `delivered` (T/F indicating whether toys have been delivered)

- There is a `Toy` object with two properties: `name` and `Child` (indicating to which Child the Toy belongs)

Unit Tests are written to validate program functionality. 


### Specs
Upon launch, the Main Menu displays:
```
WELCOME TO THE BAG O' LOOT SYSTEM
*********************************
1. Add a child
2. Assign toy to a child
3. Remove toy from child
4. Review child's toy list
5. Child toy delivery complete
6. Yuletime Delivery Report
7. Quit
> 
```

- Completed functionality for all menu options, with correct output
- Wrote in error-handling, so (for most cases) app returns to Main Menu at unexpected user input, vs app crash. e.g. If user presses `Return` with no response. 
- All Unit Tests pass
- Refactored the code. Code blocks that are repeated were extracted to methods, and then called. 

#### Unit Tests
- `ChildRegisterShould` ...
  -- `AddChildren`
  -- `ReturnListOfChildren`
  -- `GetAChild`
  -- `SetDeliveredStatusForChild`
  
- `ToyRegisterShould` ... 
  -- `AddToy`
  -- `GetToyListForChild`
  -- `RevokeToyFromChild`


### Technologies Used
- `C#`
- Visual Studio Code


```
git clone https://github.com/nss-evening-cohort-05/bag-o-loot-SMITHsharon.git
cd bag-o-loot-SMITHsharon
```

### Contributor
[Sharon Smith](https://github.com/SMITHsharon)
