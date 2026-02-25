namespace Unity.Jobs;

[JobProducerType(typeof(JobParallelForBatchProducer`1))]
[Token(Token = "0x2000006")]
public interface IJobParallelForBatch
{

	[Token(Token = "0x6000008")]
	public void Execute(int startIndex, int count) { }

}

