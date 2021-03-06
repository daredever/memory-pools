﻿namespace MemoryPools.Collections.Specialized
{
	public sealed class PoolingQueueRef<T> : PoolingQueue<T> where T : class
	{
		protected override IPoolingNode<T> CreateNodeHolder()
		{
			return (IPoolingNode<T>) Heap.Get<PoolingNodeRef<T>>().Init(PoolsDefaults.DefaultPoolBucketSize);
		}
	}
}