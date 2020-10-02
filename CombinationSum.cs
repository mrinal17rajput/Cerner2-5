//cerner_2^5_2020
public class Solution {
    // memo[atIndex] = <remSum, lists> .. stores lists that can be created with the remaining sum from index i onward
    private Dictionary<int, IList<IList<int>>>[] memo;
    
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {   
        memo = new Dictionary<int, IList<IList<int>>>[candidates.Length];
        return GetLists(candidates, target, 0, target);
    }
    
    private IList<IList<int>> GetLists(int[] candidates, int target, int i, int remSum) {
        IList<IList<int>> ret = new List<IList<int>>();
        if (memo[i] == null) memo[i] = new Dictionary<int, IList<IList<int>>>();
        if (memo[i].ContainsKey(remSum)) return memo[i][remSum];
        
        for (int j = i; j < candidates.Length; j++) {
            if (remSum - candidates[j] == 0) {
                ret.Add(new List<int> {candidates[j]});
            } else if (remSum - candidates[j] > 0) {
                IList<IList<int>> lists = GetLists(candidates, target, j, remSum - candidates[j]);
                if (lists.Count > 0) {
                    foreach (IList<int> list in lists) {
                        IList<int> l = new List<int> {candidates[j]};
                        foreach (int n in list) l.Add(n);
                        ret.Add(l);
                    }
                }
            }
        }
        
        memo[i][remSum] = ret;
        return ret;
    }
}