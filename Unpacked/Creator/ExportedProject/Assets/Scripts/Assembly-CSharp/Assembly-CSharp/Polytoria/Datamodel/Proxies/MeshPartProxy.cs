namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003AC")]
public class MeshPartProxy : PartProxy
{
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000FF6")]
	private readonly MeshPart meshPart; //Field offset: 0x28

	[Token(Token = "0x17000BB7")]
	public int AssetID
	{
		[Address(RVA = "0x4A5AF0", Offset = "0x4A4CF0", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002786")]
		 get { } //Length: 29
		[Address(RVA = "0x4A5B90", Offset = "0x4A4D90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshPart), Member = "set_AssetID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002787")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BBB")]
	public CollisionType CollisionType
	{
		[Address(RVA = "0x4A5B10", Offset = "0x4A4D10", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002791")]
		 get { } //Length: 29
		[Address(RVA = "0x4A5BB0", Offset = "0x4A4DB0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshPart), Member = "set_CollisionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollisionType)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002792")]
		 set { } //Length: 30
	}

	[Token(Token = "0x17000BB8")]
	public string CurrentAnimation
	{
		[Address(RVA = "0x4A5B30", Offset = "0x4A4D30", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshPart), Member = "get_CurrentAnimation", ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002788")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BB9")]
	public bool IsAnimationPlaying
	{
		[Address(RVA = "0x4A5B50", Offset = "0x4A4D50", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshPart), Member = "get_IsAnimationPlaying", ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002789")]
		 get { } //Length: 29
	}

	[Token(Token = "0x17000BBA")]
	public bool PlayAnimationOnStart
	{
		[Address(RVA = "0x4A5B70", Offset = "0x4A4D70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600278A")]
		 get { } //Length: 30
		[Address(RVA = "0x4A5BD0", Offset = "0x4A4DD0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(MeshPart), Member = "set_PlayAnimationOnStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600278B")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A17F0", Offset = "0x4A09F0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002785")]
	public MeshPartProxy(MeshPart target) { }

	[Address(RVA = "0x4A5AF0", Offset = "0x4A4CF0", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002786")]
	public int get_AssetID() { }

	[Address(RVA = "0x4A5B10", Offset = "0x4A4D10", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002791")]
	public CollisionType get_CollisionType() { }

	[Address(RVA = "0x4A5B30", Offset = "0x4A4D30", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "get_CurrentAnimation", ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002788")]
	public string get_CurrentAnimation() { }

	[Address(RVA = "0x4A5B50", Offset = "0x4A4D50", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "get_IsAnimationPlaying", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002789")]
	public bool get_IsAnimationPlaying() { }

	[Address(RVA = "0x4A5B70", Offset = "0x4A4D70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600278A")]
	public bool get_PlayAnimationOnStart() { }

	[Address(RVA = "0x4A5A40", Offset = "0x4A4C40", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "GetAnimationInfo", ReturnType = typeof(AnimationInfo[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002790")]
	public AnimationInfo[] GetAnimationInfo() { }

	[Address(RVA = "0x4A5A80", Offset = "0x4A4C80", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "GetAnimations", ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600278E")]
	public String[] GetAnimations() { }

	[Address(RVA = "0x4A5A60", Offset = "0x4A4C60", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "GetAnimationSources", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(String[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600278F")]
	public String[] GetAnimationSources(string animationName) { }

	[Address(RVA = "0x4A5AA0", Offset = "0x4A4CA0", Length = "0x2D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "PlayAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600278C")]
	public void PlayAnimation(string animationName, string objectPath, float speed = 1, bool loop = true) { }

	[Address(RVA = "0x4A5B90", Offset = "0x4A4D90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "set_AssetID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002787")]
	public void set_AssetID(int value) { }

	[Address(RVA = "0x4A5BB0", Offset = "0x4A4DB0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "set_CollisionType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CollisionType)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002792")]
	public void set_CollisionType(CollisionType value) { }

	[Address(RVA = "0x4A5BD0", Offset = "0x4A4DD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "set_PlayAnimationOnStart", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600278B")]
	public void set_PlayAnimationOnStart(bool value) { }

	[Address(RVA = "0x4A5AD0", Offset = "0x4A4CD0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MeshPart), Member = "StopAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600278D")]
	public void StopAnimation(string name = null) { }

}

