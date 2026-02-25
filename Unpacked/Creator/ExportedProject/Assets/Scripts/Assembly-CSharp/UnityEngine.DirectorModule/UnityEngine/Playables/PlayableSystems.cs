namespace UnityEngine.Playables;

[NativeHeader("Modules/Director/ScriptBindings/PlayableSystems.bindings.h")]
[StaticAccessor("PlayableSystemsBindings", StaticAccessorType::DoubleColon (2))]
[Token(Token = "0x2000005")]
internal static class PlayableSystems
{
	[DefaultMember("Item")]
	[Token(Token = "0x2000008")]
	private class DataPlayableOutputList : IReadOnlyList<DataPlayableOutput>, IEnumerable<DataPlayableOutput>, IEnumerable, IReadOnlyCollection<DataPlayableOutput>
	{
		[Token(Token = "0x2000009")]
		private class DataPlayableOutputEnumerator : IEnumerator<DataPlayableOutput>, IEnumerator, IDisposable
		{
			[FieldOffset(Offset = "0x10")]
			[Token(Token = "0x4000012")]
			private DataPlayableOutputList m_List; //Field offset: 0x10
			[FieldOffset(Offset = "0x18")]
			[Token(Token = "0x4000013")]
			private int m_Index; //Field offset: 0x18

			[Token(Token = "0x17000003")]
			public override DataPlayableOutput Current
			{
				[Address(RVA = "0x19940C0", Offset = "0x19932C0", Length = "0x1B5")]
				[CalledBy(Type = typeof(DataPlayableOutputEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[CallerCount(Count = 1)]
				[Calls(Type = typeof(DataPlayableOutput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
				[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
				[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
				[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
				[Token(Token = "0x6000013")]
				 get { } //Length: 437
			}

			[Token(Token = "0x17000004")]
			private override object System.Collections.IEnumerator.Current
			{
				[Address(RVA = "0x1994060", Offset = "0x1993260", Length = "0x54")]
				[CallerCount(Count = 0)]
				[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
				[Calls(Type = typeof(DataPlayableOutputEnumerator), Member = "get_Current", ReturnType = typeof(DataPlayableOutput))]
				[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
				[Token(Token = "0x6000014")]
				private get { } //Length: 84
			}

			[Address(RVA = "0x140E2F0", Offset = "0x140D4F0", Length = "0x39")]
			[CallerCount(Count = 2)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[CallsDeduplicatedMethods(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000012")]
			public DataPlayableOutputEnumerator(DataPlayableOutputList list) { }

			[Address(RVA = "0x13D6400", Offset = "0x13D5600", Length = "0x13")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
			[DeduplicatedMethod]
			[Token(Token = "0x6000015")]
			public override void Dispose() { }

			[Address(RVA = "0x19940C0", Offset = "0x19932C0", Length = "0x1B5")]
			[CalledBy(Type = typeof(DataPlayableOutputEnumerator), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
			[CallerCount(Count = 1)]
			[Calls(Type = typeof(DataPlayableOutput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002F80")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[Token(Token = "0x6000013")]
			public override DataPlayableOutput get_Current() { }

			[Address(RVA = "0x1994030", Offset = "0x1993230", Length = "0x25")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[ContainsUnimplementedInstructions]
			[Token(Token = "0x6000016")]
			public override bool MoveNext() { }

			[Address(RVA = "0x14CF520", Offset = "0x14CE720", Length = "0x8")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x6000017")]
			public override void Reset() { }

			[Address(RVA = "0x1994060", Offset = "0x1993260", Length = "0x54")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = typeof(DataPlayableOutputEnumerator), Member = "get_Current", ReturnType = typeof(DataPlayableOutput))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Token(Token = "0x6000014")]
			private override object System.Collections.IEnumerator.get_Current() { }

		}

		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000010")]
		private PlayableOutputHandle* m_Outputs; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000011")]
		private int m_Count; //Field offset: 0x18

		[Token(Token = "0x17000002")]
		public override int Count
		{
			[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			[Token(Token = "0x600000F")]
			 get { } //Length: 4
		}

		[Token(Token = "0x17000001")]
		public override DataPlayableOutput Item
		{
			[Address(RVA = "0x1994330", Offset = "0x1993530", Length = "0x149")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(DataPlayableOutput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
			[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
			[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
			[Token(Token = "0x600000E")]
			 get { } //Length: 329
		}

		[Address(RVA = "0x19942F0", Offset = "0x19934F0", Length = "0x36")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600000D")]
		public DataPlayableOutputList(PlayableOutputHandle* outputs, int count) { }

		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000F")]
		public override int get_Count() { }

		[Address(RVA = "0x1994330", Offset = "0x1993530", Length = "0x149")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DataPlayableOutput), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PlayableOutputHandle)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600000E")]
		public override DataPlayableOutput get_Item(int index) { }

		[Address(RVA = "0x1994280", Offset = "0x1993480", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000010")]
		public override IEnumerator<DataPlayableOutput> GetEnumerator() { }

		[Address(RVA = "0x1994280", Offset = "0x1993480", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000011")]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	}

	[Token(Token = "0x2000006")]
	internal sealed class PlayableSystemDelegate : MulticastDelegate
	{

		[Address(RVA = "0x1994810", Offset = "0x1993A10", Length = "0x124")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE410")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[Token(Token = "0x600000B")]
		public PlayableSystemDelegate(object object, IntPtr method) { }

		[Address(RVA = "0x309260", Offset = "0x308460", Length = "0xF")]
		[CallerCount(Count = 3)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600000C")]
		public override void Invoke(IReadOnlyList<DataPlayableOutput> outputs) { }

	}

	[Token(Token = "0x2000007")]
	internal enum PlayableSystemStage
	{
		FixedUpdate = 0,
		FixedUpdatePostPhysics = 1,
		Update = 2,
		AnimationBegin = 3,
		AnimationEnd = 4,
		LateUpdate = 5,
		Render = 6,
	}

	[Token(Token = "0x4000005")]
	private static Dictionary<Int32, Type> s_SystemTypes; //Field offset: 0x0
	[Token(Token = "0x4000006")]
	private static Dictionary<Int32, PlayableSystemDelegate> s_Delegates; //Field offset: 0x8
	[Token(Token = "0x4000007")]
	private static ReaderWriterLockSlim s_RWLock; //Field offset: 0x10

	[Address(RVA = "0x1994B50", Offset = "0x1993D50", Length = "0x188")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Dictionary`2), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[ContainsInvalidInstructions]
	[Token(Token = "0x600000A")]
	private static PlayableSystems() { }

	[Address(RVA = "0x1994940", Offset = "0x1993B40", Length = "0xB")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000008")]
	private static int CombineTypeAndIndex(int typeIndex, PlayableSystemStage stage) { }

	[Address(RVA = "0x1994950", Offset = "0x1993B50", Length = "0x1F0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "EnterReadLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Int32, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ReaderWriterLockSlim), Member = "ExitReadLock", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[RequiredByNativeCode]
	[Token(Token = "0x6000009")]
	private static bool Internal_CallSystemDelegate(int systemIndex, PlayableSystemStage stage, IntPtr outputsPtr, int numOutputs) { }

}

