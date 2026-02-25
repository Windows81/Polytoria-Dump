namespace Unity.Jobs;

[JobProducerType(typeof(ParallelForJobStruct`1))]
[Token(Token = "0x200000D")]
public interface IJobParallelFor
{

	[Token(Token = "0x6000012")]
	public void Execute(int index) { }

}

