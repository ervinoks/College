using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L220
{
	internal class Program
	{
		static int GetValueFromPriorityQueue(Dictionary<int, int> priorityQueue)
		{
			int bestNode = priorityQueue.Keys.First();
			int bestPriority = priorityQueue[bestNode];

			foreach (int key in priorityQueue.Keys)
			{
				if (priorityQueue[key] < bestPriority)
				{
					bestNode = key;
					bestPriority = priorityQueue[key];
				}
			}
			return bestNode;
		}
		static int Djikstras(int[,] graph, int startNode, int endNode)
		{
			int[] bestDistances = new int[graph.GetLength(0)];
			int[] parentNode = new int[graph.GetLength(0)];
			Dictionary<int, int> priorityQueue = new Dictionary<int, int>(); // here we store the node and its best distances
																			 // program dijkstras
			priorityQueue.Add(startNode, 0);
			while (priorityQueue.Keys.Count > 0)
			{
				int nextNode = GetValueFromPriorityQueue(priorityQueue);
				bestDistances[nextNode] = priorityQueue[nextNode];
				priorityQueue.Remove(nextNode);
				for (int i = 0; i < graph.GetLength(0); i++)
				{
					if (graph[nextNode, i] > 0)
					{
						if (priorityQueue.ContainsKey(i))
						{
							if (priorityQueue[i] > graph[nextNode, i] + bestDistances[nextNode])
							{
								priorityQueue[i] = graph[nextNode, i] + bestDistances[nextNode];
								parentNode[i] = nextNode;
							}
						}
						else
						{
							priorityQueue.Add(i, graph[nextNode, i] + bestDistances[nextNode]);
							parentNode[i] = nextNode;
						}
					}
				}
			}
			return bestDistances[endNode];
		}
		static void Main(string[] args)
		{
			int[,] graph = new int[6, 6];
			graph[0, 1] = 3;
			graph[0, 3] = 9;
			graph[0, 4] = 8;
			graph[1, 2] = 1;
			graph[2, 3] = 2;
			graph[2, 5] = 11;
			graph[3, 4] = 3;
			graph[3, 5] = 2;
			graph[4, 5] = 5;
			foreach (var d in graph)
			{
				
			}
		}
	}
}
