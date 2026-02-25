namespace Unity.Burst;

[Token(Token = "0x200001D")]
internal static class SharedStatic
{
	[Token(Token = "0x200001E")]
	public class PreserveAttribute : Attribute
	{

		[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
		[CallerCount(Count = 83)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600007B")]
		public PreserveAttribute() { }

	}


	[Address(RVA = "0x181F280", Offset = "0x181E480", Length = "0x48")]
	[CalledBy(Type = typeof(SharedStatic`1), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = "Unity.Burst.SharedStatic`1<T>")]
	[CallerCount(Count = 1)]
	[Calls(Type = "Unity.Burst.LowLevel.BurstCompilerService", Member = "GetOrCreateSharedMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Hash128&), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Preserve]
	[Token(Token = "0x600007A")]
	public static Void* GetOrCreateSharedStaticInternal(long getHashCode64, long getSubHashCode64, uint sizeOf, uint alignment) { }

}

