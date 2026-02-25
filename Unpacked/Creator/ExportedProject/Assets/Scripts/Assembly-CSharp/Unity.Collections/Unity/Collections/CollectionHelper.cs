namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000019")]
public static class CollectionHelper
{
	[BurstCompile]
	[Token(Token = "0x200001A")]
	internal struct DummyJob : IJob
	{

		[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
		[CallerCount(Count = 8626)]
		[DeduplicatedMethod]
		[Token(Token = "0x600003E")]
		public override void Execute() { }

	}


	[Address(RVA = "0x64EB60", Offset = "0x64DD60", Length = "0x3")]
	[CallerCount(Count = 29)]
	[DeduplicatedMethod]
	[Token(Token = "0x600003D")]
	internal static int AssumePositive(int value) { }

	[Address(RVA = "0x18203C0", Offset = "0x181F5C0", Length = "0x14")]
	[CalledBy(Type = typeof(UnsafeList`1), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeRingQueue`1), Member = "Dispose", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600003C")]
	internal static bool ShouldDeallocate(AllocatorHandle allocator) { }

}

