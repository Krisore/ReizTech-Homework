
namespace Assignment2_HierarchicalStructure;
public class Branch
{
    public string Name { get; set; }
    public List<Branch> Branches { get; set; }

    public Branch(string name)
    {
        Name = name;
        Branches = new List<Branch>();
    }

    public void AddBranch(Branch branch)
    {
        Branches.Add(branch);
    }

    public int GetDepth()
    {
        if (Branches.Count == 0)
        {
            return 1;
        }
        else
        {
            int maxDepth = 0;
            foreach (var branch in Branches)
            {
                int depth = branch.GetDepth();
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }
            return maxDepth + 1;
        }
    }
}
