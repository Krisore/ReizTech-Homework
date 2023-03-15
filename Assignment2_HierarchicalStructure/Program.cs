using Assignment2_HierarchicalStructure;

Branch root = new Branch("root");

Branch branch1 = new Branch("branch1");
branch1.AddBranch(new Branch("branch1.1"));
branch1.AddBranch(new Branch("branch1.2"));
branch1.AddBranch(new Branch("branch1.3"));

Branch branch2 = new Branch("branch2");
branch2.AddBranch(new Branch("branch2.1"));
branch2.AddBranch(new Branch("branch2.2"));

Branch branch3 = new Branch("branch3");
branch3.AddBranch(new Branch("branch3.1"));

Branch branch4 = new Branch("branch4");
branch4.AddBranch(new Branch("branch4.1"));
branch4.AddBranch(new Branch("branch4.2"));

Branch branch5 = new Branch("branch5");
branch5.AddBranch(new Branch("branch5.1"));
branch5.AddBranch(new Branch("branch5.2"));
branch5.AddBranch(new Branch("branch5.3"));
branch5.AddBranch(new Branch("branch5.4"));


root.AddBranch(branch1);
root.AddBranch(branch2);
root.AddBranch(branch3);
root.AddBranch(branch4);
root.AddBranch(branch5);


int depth = root.GetDepth();
Console.WriteLine($"Depth: {depth}"); // Output: Depth: 5