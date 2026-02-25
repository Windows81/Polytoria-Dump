namespace UnityEngine;

[DefaultMember("Item")]
[NativeHeader("Modules/Animation/Animation.h")]
[Token(Token = "0x2000006")]
public sealed class Animation : Behaviour, IEnumerable
{
	[Token(Token = "0x2000007")]
	private sealed class Enumerator : IEnumerator
	{
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000008")]
		private Animation m_Outer; //Field offset: 0x10
		[FieldOffset(Offset = "0x18")]
		[Token(Token = "0x4000009")]
		private int m_CurrentIndex; //Field offset: 0x18

		[Token(Token = "0x17000004")]
		public override object Current
		{
			[Address(RVA = "0x1917500", Offset = "0x1916700", Length = "0x85")]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
			[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
			[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
			[CallsUnknownMethods(Count = 1)]
			[Token(Token = "0x6000030")]
			 get { } //Length: 133
		}

		[Address(RVA = "0x166B7E0", Offset = "0x166A9E0", Length = "0x38")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		internal Enumerator(Animation outer) { }

		[Address(RVA = "0x1917500", Offset = "0x1916700", Length = "0x85")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000030")]
		public override object get_Current() { }

		[Address(RVA = "0x1917460", Offset = "0x1916660", Length = "0x90")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000031")]
		public override bool MoveNext() { }

		[Address(RVA = "0x14CF520", Offset = "0x14CE720", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		public override void Reset() { }

	}


	[Token(Token = "0x17000001")]
	public AnimationClip clip
	{
		[Address(RVA = "0x1914950", Offset = "0x1913B50", Length = "0x90")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "get_CurrentAnimation", ReturnType = typeof(string))]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B5340")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000010")]
		 get { } //Length: 144
		[Address(RVA = "0x1914B00", Offset = "0x1913D00", Length = "0xBA")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip[]"}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000011")]
		 set { } //Length: 186
	}

	[Token(Token = "0x17000002")]
	public bool isPlaying
	{
		[Address(RVA = "0x1914A30", Offset = "0x1913C30", Length = "0x76")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "get_CurrentAnimation", ReturnType = typeof(string))]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "get_IsAnimationPlaying", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeName("IsPlaying")]
		[Token(Token = "0x6000015")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000003")]
	public AnimationState Item
	{
		[Address(RVA = "0x1914900", Offset = "0x1913B00", Length = "0xA")]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Animation), Member = "GetState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AnimationState))]
		[Token(Token = "0x6000017")]
		 get { } //Length: 10
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000023")]
	public Animation() { }

	[Address(RVA = "0x1913BA0", Offset = "0x1912DA0", Length = "0x244")]
	[CalledBy(Type = typeof(Animation), Member = "AddClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Animation), Member = "AddClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600001D")]
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	[Address(RVA = "0x1913B40", Offset = "0x1912D40", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animation), Member = "AddClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[ExcludeFromDocs]
	[Token(Token = "0x600001C")]
	public void AddClip(AnimationClip clip, string newName, int firstFrame, int lastFrame) { }

	[Address(RVA = "0x1913B70", Offset = "0x1912D70", Length = "0x2A")]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animation), Member = "AddClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(AnimationClip), typeof(string), typeof(int), typeof(int), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x600001B")]
	public void AddClip(AnimationClip clip, string newName) { }

	[Address(RVA = "0x1913AD0", Offset = "0x1912CD0", Length = "0x6D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002B")]
	private static void AddClip_Injected(IntPtr _unity_self, IntPtr clip, ref ManagedSpanWrapper newName, int firstFrame, int lastFrame, bool addLoopFrame) { }

	[Address(RVA = "0x1914950", Offset = "0x1913B50", Length = "0x90")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "get_CurrentAnimation", ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B5340")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000010")]
	public AnimationClip get_clip() { }

	[Address(RVA = "0x1914910", Offset = "0x1913B10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000024")]
	private static IntPtr get_clip_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1914A30", Offset = "0x1913C30", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "get_CurrentAnimation", ReturnType = typeof(string))]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "get_IsAnimationPlaying", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("IsPlaying")]
	[Token(Token = "0x6000015")]
	public bool get_isPlaying() { }

	[Address(RVA = "0x19149F0", Offset = "0x1913BF0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000028")]
	private static bool get_isPlaying_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1914900", Offset = "0x1913B00", Length = "0xA")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "GetAnimationInfo", ReturnType = "Polytoria.Datamodel.AnimationInfo[]")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animation), Member = "GetState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AnimationState))]
	[Token(Token = "0x6000017")]
	public AnimationState get_Item(string name) { }

	[Address(RVA = "0x1913DF0", Offset = "0x1912FF0", Length = "0xA9")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animation), Member = "GetState", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AnimationState))]
	[Calls(Type = typeof(TrackedReference), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TrackedReference)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801B5340")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000022")]
	public AnimationClip GetClip(string name) { }

	[Address(RVA = "0x1913EA0", Offset = "0x19130A0", Length = "0x67")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "RefreshAnimationComponents", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600001E")]
	public override IEnumerator GetEnumerator() { }

	[Address(RVA = "0x19140F0", Offset = "0x19132F0", Length = "0x1BE")]
	[CalledBy(Type = typeof(Animation), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AnimationState))]
	[CalledBy(Type = typeof(Animation), Member = "GetClip", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(AnimationClip))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationBindings::GetState", HasExplicitThis = True)]
	[Token(Token = "0x600001F")]
	internal AnimationState GetState(string name) { }

	[Address(RVA = "0x19140A0", Offset = "0x19132A0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002C")]
	private static AnimationState GetState_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x1913F50", Offset = "0x1913150", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("AnimationBindings::GetStateAtIndex", HasExplicitThis = True, ThrowsException = True)]
	[Token(Token = "0x6000020")]
	internal AnimationState GetStateAtIndex(int index) { }

	[Address(RVA = "0x1913F10", Offset = "0x1913110", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002D")]
	private static AnimationState GetStateAtIndex_Injected(IntPtr _unity_self, int index) { }

	[Address(RVA = "0x1914020", Offset = "0x1913220", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("GetAnimationStateCount")]
	[Token(Token = "0x6000021")]
	internal int GetStateCount() { }

	[Address(RVA = "0x1913FE0", Offset = "0x19131E0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002E")]
	private static int GetStateCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1914300", Offset = "0x1913500", Length = "0x1CB")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "StopAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000016")]
	public bool IsPlaying(string name) { }

	[Address(RVA = "0x19142B0", Offset = "0x19134B0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000029")]
	private static bool IsPlaying_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x1914510", Offset = "0x1913710", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000019")]
	public bool Play(PlayMode mode) { }

	[Address(RVA = "0x19145A0", Offset = "0x19137A0", Length = "0x78")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GltfAsset", Member = "PostInstantiation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"GLTFast.IInstantiator", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ExcludeFromDocs]
	[Token(Token = "0x6000018")]
	public bool Play() { }

	[Address(RVA = "0x1914510", Offset = "0x1913710", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[NativeName("Play")]
	[Token(Token = "0x600001A")]
	private bool PlayDefaultAnimation(PlayMode mode) { }

	[Address(RVA = "0x19144D0", Offset = "0x19136D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600002A")]
	private static bool PlayDefaultAnimation_Injected(IntPtr _unity_self, PlayMode mode) { }

	[Address(RVA = "0x1914B00", Offset = "0x1913D00", Length = "0xBA")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "GLTFast.GameObjectInstantiator", Member = "AddAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AnimationClip[]"}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	public void set_clip(AnimationClip value) { }

	[Address(RVA = "0x1914AB0", Offset = "0x1913CB0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000025")]
	private static void set_clip_Injected(IntPtr _unity_self, IntPtr value) { }

	[Address(RVA = "0x1914880", Offset = "0x1913A80", Length = "0x76")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "StopAllAnimations", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000012")]
	public void Stop() { }

	[Address(RVA = "0x1914870", Offset = "0x1913A70", Length = "0x8")]
	[CalledBy(Type = "Polytoria.Datamodel.MeshPart", Member = "StopAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animation), Member = "StopNamed", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000013")]
	public void Stop(string name) { }

	[Address(RVA = "0x1914830", Offset = "0x1913A30", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000026")]
	private static void Stop_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1914670", Offset = "0x1913870", Length = "0x1B5")]
	[CalledBy(Type = typeof(Animation), Member = "Stop", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeName("Stop")]
	[Token(Token = "0x6000014")]
	private void StopNamed(string name) { }

	[Address(RVA = "0x1914620", Offset = "0x1913820", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000027")]
	private static void StopNamed_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

}

