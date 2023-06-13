using System;
namespace CSharpFundamentalsAssignment {
	
	class BudgetInfo {
		
		static void Main(string[] args) {
			
            int[] budget = new int[5];
            int i;
            for(i = 0; i < 5;i++)
            {
                budget[i] = Console.ReadLine();
            }
			Console.ReadKey();
		}
	}
}
