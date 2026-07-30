using Day03_Operators;

Console.WriteLine("============== Operators Examples ==================");
OperatorExamples.RunArithmeticExamples();
OperatorExamples.RunAssignmentExamples();
OperatorExamples.RunComparisonExamples();
OperatorExamples.RunLogicalExamples();
OperatorExamples.RunIncrementDecrementExamples();

Console.WriteLine("\n============== Conditional Examples ==================");
ConditionalExamples.RunIfExample();
ConditionalExamples.RunIfElseExample();
ConditionalExamples.RunElseIfExample();
ConditionalExamples.RunNestedIfExample();
ConditionalExamples.RunTernaryOperatorExample();

Console.WriteLine("\n============== Switch Examples ==================");
SwitchExamples.RunDayExample();
SwitchExamples.RunGradeExample();
SwitchExamples.RunCalculatorExample();
SwitchExamples.RunMonthExample();

Console.WriteLine("\n============== Loop Examples ==================");
LoopExamples.RunForLoopExample();
LoopExamples.RunWhileLoopExample();
LoopExamples.RunDoWhileLoopExample();
LoopExamples.RunForeachLoopExample();
LoopExamples.RunBreakExample();
LoopExamples.RunContinueExample();
LoopExamples.RunMultiplicationTableExample();

Console.WriteLine("\n============== Method Examples ==================");
MethodExample.RunWelcomeExample();
MethodExample.RunGreetingExample("Pradip");
int currentYear = MethodExample.RunCurrentYearExample();
Console.WriteLine($"Current Year is: {currentYear}");
int area = MethodExample.RunCalculateRectangleAreaExample(10, 5);
Console.WriteLine($"Area of Rectangle (10 x 5) is: {area}");