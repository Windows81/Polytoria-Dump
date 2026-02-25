namespace UnityEngine;

[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
[NativeHeader("Modules/Animation/Animator.h")]
[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
[Token(Token = "0x2000013")]
[UsedByNativeCode]
public class Animator : Behaviour
{

	[Token(Token = "0x17000012")]
	public bool hasBoundPlayables
	{
		[Address(RVA = "0x19170C0", Offset = "0x19162C0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("HasBoundPlayables")]
		[Token(Token = "0x6000073")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700000F")]
	public int layerCount
	{
		[Address(RVA = "0x1917180", Offset = "0x1916380", Length = "0x76")]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "Initialize", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnDeserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600005F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000010")]
	public AnimatorControllerParameter[] parameters
	{
		[Address(RVA = "0x1917240", Offset = "0x1916440", Length = "0x76")]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "Initialize", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
		[Token(Token = "0x6000068")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000011")]
	public float speed
	{
		[Address(RVA = "0x1917300", Offset = "0x1916500", Length = "0x76")]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "CheckSpeed", ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000069")]
		 get { } //Length: 118
		[Address(RVA = "0x19173D0", Offset = "0x19165D0", Length = "0x86")]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnAnimatorSpeedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "UserCode_CmdSetAnimatorSpeed__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkAnimator", Member = "InvokeUserCode_CmdSetAnimatorSpeed__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x600006A")]
		 set { } //Length: 134
	}

	[Address(RVA = "0x2C7050", Offset = "0x2C6250", Length = "0x7")]
	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000082")]
	public Animator() { }

	[Address(RVA = "0x1915100", Offset = "0x1914300", Length = "0xC7")]
	[CalledBy(Type = "Polytoria.Datamodel.Player+<StopScream>d__209", Member = "MoveNext", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "StringToHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006B")]
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer) { }

	[Address(RVA = "0x1915280", Offset = "0x1914480", Length = "0xBD")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Unsit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "StringToHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006C")]
	public void CrossFade(string stateName, float normalizedTransitionDuration) { }

	[Address(RVA = "0x1915340", Offset = "0x1914540", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "StringToHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006D")]
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x19151D0", Offset = "0x19143D0", Length = "0xA3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = True)]
	[Token(Token = "0x600006E")]
	public void CrossFade(int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x19150A0", Offset = "0x19142A0", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008C")]
	private static void CrossFade_Injected(IntPtr _unity_self, int stateHashName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset, float normalizedTransitionTime) { }

	[Address(RVA = "0x19170C0", Offset = "0x19162C0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("HasBoundPlayables")]
	[Token(Token = "0x6000073")]
	public bool get_hasBoundPlayables() { }

	[Address(RVA = "0x1917080", Offset = "0x1916280", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008E")]
	private static bool get_hasBoundPlayables_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1917180", Offset = "0x1916380", Length = "0x76")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "Initialize", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnDeserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600005F")]
	public int get_layerCount() { }

	[Address(RVA = "0x1917140", Offset = "0x1916340", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000083")]
	private static int get_layerCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1917240", Offset = "0x1916440", Length = "0x76")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "Initialize", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "AnimatorBindings::GetParameters", HasExplicitThis = True)]
	[Token(Token = "0x6000068")]
	public AnimatorControllerParameter[] get_parameters() { }

	[Address(RVA = "0x1917200", Offset = "0x1916400", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000089")]
	private static AnimatorControllerParameter[] get_parameters_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1917300", Offset = "0x1916500", Length = "0x76")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "CheckSpeed", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000069")]
	public float get_speed() { }

	[Address(RVA = "0x19172C0", Offset = "0x19164C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008A")]
	private static float get_speed_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1915460", Offset = "0x1914660", Length = "0xA7")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000062")]
	private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	[Address(RVA = "0x1915400", Offset = "0x1914600", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000086")]
	private static void GetAnimatorStateInfo_Injected(IntPtr _unity_self, int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info) { }

	[Address(RVA = "0x1915560", Offset = "0x1914760", Length = "0x93")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000065")]
	private void GetAnimatorTransitionInfo(int layerIndex, out AnimatorTransitionInfo info) { }

	[Address(RVA = "0x1915600", Offset = "0x1914800", Length = "0xC1")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "CheckAnimStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Single&), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000066")]
	public AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex) { }

	[Address(RVA = "0x1915510", Offset = "0x1914710", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000087")]
	private static void GetAnimatorTransitionInfo_Injected(IntPtr _unity_self, int layerIndex, out AnimatorTransitionInfo info) { }

	[Address(RVA = "0x1915710", Offset = "0x1914910", Length = "0x83")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000054")]
	public bool GetBool(int id) { }

	[Address(RVA = "0x1915710", Offset = "0x1914910", Length = "0x83")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::GetBoolID", HasExplicitThis = True)]
	[Token(Token = "0x6000079")]
	private bool GetBoolID(int id) { }

	[Address(RVA = "0x19156D0", Offset = "0x19148D0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000094")]
	private static bool GetBoolID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x19157A0", Offset = "0x19149A0", Length = "0xD3")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "CheckAnimStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Single&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000063")]
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex) { }

	[Address(RVA = "0x19158C0", Offset = "0x1914AC0", Length = "0x83")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000052")]
	public float GetFloat(int id) { }

	[Address(RVA = "0x19158C0", Offset = "0x1914AC0", Length = "0x83")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = True)]
	[Token(Token = "0x6000076")]
	private float GetFloatID(int id) { }

	[Address(RVA = "0x1915880", Offset = "0x1914A80", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000091")]
	private static float GetFloatID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x1915990", Offset = "0x1914B90", Length = "0x83")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000057")]
	public int GetInteger(int id) { }

	[Address(RVA = "0x1915990", Offset = "0x1914B90", Length = "0x83")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::GetIntegerID", HasExplicitThis = True)]
	[Token(Token = "0x600007C")]
	private int GetIntegerID(int id) { }

	[Address(RVA = "0x1915950", Offset = "0x1914B50", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000097")]
	private static int GetIntegerID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x1915A60", Offset = "0x1914C60", Length = "0x83")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "CheckAnimStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Single&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000060")]
	public float GetLayerWeight(int layerIndex) { }

	[Address(RVA = "0x1915A20", Offset = "0x1914C20", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000084")]
	private static float GetLayerWeight_Injected(IntPtr _unity_self, int layerIndex) { }

	[Address(RVA = "0x1915AF0", Offset = "0x1914CF0", Length = "0xD6")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000064")]
	public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex) { }

	[Address(RVA = "0x1915C10", Offset = "0x1914E10", Length = "0x83")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "CheckAnimStateChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(Single&), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000067")]
	public bool IsInTransition(int layerIndex) { }

	[Address(RVA = "0x1915BD0", Offset = "0x1914DD0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000088")]
	private static bool IsInTransition_Injected(IntPtr _unity_self, int layerIndex) { }

	[Address(RVA = "0x1915CE0", Offset = "0x1914EE0", Length = "0x83")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005E")]
	public bool IsParameterControlledByCurve(int id) { }

	[Address(RVA = "0x1915CE0", Offset = "0x1914EE0", Length = "0x83")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::IsParameterControlledByCurveID", HasExplicitThis = True)]
	[Token(Token = "0x6000081")]
	private bool IsParameterControlledByCurveID(int id) { }

	[Address(RVA = "0x1915CA0", Offset = "0x1914EA0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009C")]
	private static bool IsParameterControlledByCurveID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x1915FE0", Offset = "0x19151E0", Length = "0xA8")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "SendChat", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "StringToHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006F")]
	public void Play(string stateName, int layer) { }

	[Address(RVA = "0x1915DD0", Offset = "0x1914FD0", Length = "0x9E")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "UserCode_PlayAnimTargetRpc__String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "PlayAnim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "UserCode_PlayAnimTargetRpc__String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "InvokeUserCode_PlayAnimTargetRpc__String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "PlayAnim", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "SendChat", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Sit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Datamodel.Seat"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "InvokeUserCode_PlayAnimTargetRpc__String", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Animator), Member = "StringToHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000070")]
	public void Play(string stateName) { }

	[Address(RVA = "0x1915F20", Offset = "0x1915120", Length = "0xB0")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Animator), Member = "StringToHash", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000071")]
	public void Play(string stateName, int layer, float normalizedTime) { }

	[Address(RVA = "0x1915E70", Offset = "0x1915070", Length = "0xA3")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "HandleAnimMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(int), typeof(float), "Mirror.NetworkReader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnDeserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = True)]
	[Token(Token = "0x6000072")]
	public void Play(int stateNameHash, int layer, float normalizedTime) { }

	[Address(RVA = "0x1915D70", Offset = "0x1914F70", Length = "0x60")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008D")]
	private static void Play_Injected(IntPtr _unity_self, int stateNameHash, int layer, float normalizedTime) { }

	[Address(RVA = "0x19160D0", Offset = "0x19152D0", Length = "0x83")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005D")]
	public void ResetTrigger(int id) { }

	[Address(RVA = "0x1916370", Offset = "0x1915570", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Animator), Member = "ResetTriggerString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600005C")]
	public void ResetTrigger(string name) { }

	[Address(RVA = "0x19160D0", Offset = "0x19152D0", Length = "0x83")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = True)]
	[Token(Token = "0x6000080")]
	private void ResetTriggerID(int id) { }

	[Address(RVA = "0x1916090", Offset = "0x1915290", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009B")]
	private static void ResetTriggerID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x19161B0", Offset = "0x19153B0", Length = "0x1B5")]
	[CalledBy(Type = typeof(Animator), Member = "ResetTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = True)]
	[Token(Token = "0x600007F")]
	private void ResetTriggerString(string name) { }

	[Address(RVA = "0x1916160", Offset = "0x1915360", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600009A")]
	private static void ResetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x19173D0", Offset = "0x19165D0", Length = "0x86")]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnAnimatorSpeedChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "UserCode_CmdSetAnimatorSpeed__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "InvokeUserCode_CmdSetAnimatorSpeed__Single", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkBehaviour", "Mirror.NetworkReader", "Mirror.NetworkConnectionToClient"}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600006A")]
	public void set_speed(float value) { }

	[Address(RVA = "0x1917380", Offset = "0x1916580", Length = "0x43")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008B")]
	private static void set_speed_Injected(IntPtr _unity_self, float value) { }

	[Address(RVA = "0x19166B0", Offset = "0x19158B0", Length = "0x8")]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.NPC", Member = "MoveDirection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(Animator), Member = "SetBoolString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000055")]
	public void SetBool(string name, bool value) { }

	[Address(RVA = "0x19163E0", Offset = "0x19155E0", Length = "0x95")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000056")]
	public void SetBool(int id, bool value) { }

	[Address(RVA = "0x19163E0", Offset = "0x19155E0", Length = "0x95")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = True)]
	[Token(Token = "0x6000078")]
	private void SetBoolID(int id, bool value) { }

	[Address(RVA = "0x1916380", Offset = "0x1915580", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000093")]
	private static void SetBoolID_Injected(IntPtr _unity_self, int id, bool value) { }

	[Address(RVA = "0x19164E0", Offset = "0x19156E0", Length = "0x1C6")]
	[CalledBy(Type = typeof(Animator), Member = "SetBool", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = True)]
	[Token(Token = "0x6000077")]
	private void SetBoolString(string name, bool value) { }

	[Address(RVA = "0x1916480", Offset = "0x1915680", Length = "0x54")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000092")]
	private static void SetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, bool value) { }

	[Address(RVA = "0x1916710", Offset = "0x1915910", Length = "0x93")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000053")]
	public void SetFloat(int id, float value) { }

	[Address(RVA = "0x1916710", Offset = "0x1915910", Length = "0x93")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = True)]
	[Token(Token = "0x6000075")]
	private void SetFloatID(int id, float value) { }

	[Address(RVA = "0x19166C0", Offset = "0x19158C0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000090")]
	private static void SetFloatID_Injected(IntPtr _unity_self, int id, float value) { }

	[Address(RVA = "0x1916800", Offset = "0x1915A00", Length = "0x93")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000059")]
	public void SetInteger(int id, int value) { }

	[Address(RVA = "0x1916AD0", Offset = "0x1915CD0", Length = "0x8")]
	[CalledBy(Type = "Polytoria.UI.MenuButtonAnimation", Member = "SetOpen", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "SetIntegerString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000058")]
	public void SetInteger(string name, int value) { }

	[Address(RVA = "0x1916800", Offset = "0x1915A00", Length = "0x93")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = True)]
	[Token(Token = "0x600007B")]
	private void SetIntegerID(int id, int value) { }

	[Address(RVA = "0x19167B0", Offset = "0x19159B0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000096")]
	private static void SetIntegerID_Injected(IntPtr _unity_self, int id, int value) { }

	[Address(RVA = "0x1916900", Offset = "0x1915B00", Length = "0x1C4")]
	[CalledBy(Type = typeof(Animator), Member = "SetInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = True)]
	[Token(Token = "0x600007A")]
	private void SetIntegerString(string name, int value) { }

	[Address(RVA = "0x19168A0", Offset = "0x1915AA0", Length = "0x52")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000095")]
	private static void SetIntegerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, int value) { }

	[Address(RVA = "0x1916B30", Offset = "0x1915D30", Length = "0x93")]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "HandleAnimMsg", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float), typeof(int), typeof(float), "Mirror.NetworkReader"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "OnDeserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000061")]
	public void SetLayerWeight(int layerIndex, float weight) { }

	[Address(RVA = "0x1916AE0", Offset = "0x1915CE0", Length = "0x50")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000085")]
	private static void SetLayerWeight_Injected(IntPtr _unity_self, int layerIndex, float weight) { }

	[Address(RVA = "0x1916EB0", Offset = "0x19160B0", Length = "0x8")]
	[CalledBy(Type = "UnityEngine.UI.Selectable", Member = "TriggerAnimation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "SetTriggerString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x600005A")]
	public void SetTrigger(string name) { }

	[Address(RVA = "0x1916C10", Offset = "0x1915E10", Length = "0x83")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600005B")]
	public void SetTrigger(int id) { }

	[Address(RVA = "0x1916C10", Offset = "0x1915E10", Length = "0x83")]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = True)]
	[Token(Token = "0x600007E")]
	private void SetTriggerID(int id) { }

	[Address(RVA = "0x1916BD0", Offset = "0x1915DD0", Length = "0x40")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000099")]
	private static void SetTriggerID_Injected(IntPtr _unity_self, int id) { }

	[Address(RVA = "0x1916CF0", Offset = "0x1915EF0", Length = "0x1B5")]
	[CalledBy(Type = typeof(Animator), Member = "SetTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = "UnityEngine.Bindings.ThrowHelper", Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = True)]
	[Token(Token = "0x600007D")]
	private void SetTriggerString(string name) { }

	[Address(RVA = "0x1916CA0", Offset = "0x1915EA0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000098")]
	private static void SetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	[Address(RVA = "0x1916F00", Offset = "0x1916100", Length = "0x17D")]
	[CalledBy(Type = typeof(Animator), Member = "Play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "SetTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkAnimator", Member = "ResetTrigger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Animator), Member = "CrossFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Animator), Member = "CrossFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Animator), Member = "CrossFade", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(float), typeof(int), typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Animator), Member = "Play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Animator), Member = "Play", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash", ReturnType = typeof(int))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = True)]
	[Token(Token = "0x6000074")]
	public static int StringToHash(string name) { }

	[Address(RVA = "0x1916EC0", Offset = "0x19160C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600008F")]
	private static int StringToHash_Injected(ref ManagedSpanWrapper name) { }

}

