namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType::Dot (0))]
[Token(Token = "0x2000181")]
public class Time
{

	[Token(Token = "0x170001C2")]
	public static float deltaTime
	{
		[Address(RVA = "0x19716B0", Offset = "0x19708B0", Length = "0x2A")]
		[CallerCount(Count = 91)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD4")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001C6")]
	public static float fixedDeltaTime
	{
		[Address(RVA = "0x19716E0", Offset = "0x19708E0", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "ApplyCameraTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkLerpRigidbody", Member = "FixedUpdate", ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD8")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001C8")]
	public static int frameCount
	{
		[Address(RVA = "0x1971710", Offset = "0x1970910", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "UpdateCurrentFrame", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "UpdateState", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "UpdateGhosting", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkServer", Member = "SerializeForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", "Mirror.NetworkConnectionToClient"}, ReturnType = "Mirror.NetworkWriter")]
		[CalledBy(Type = "Mirror.NetworkBehaviourHybrid", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkBehaviourHybrid", Member = "UpdateClientBaseline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkBehaviourHybrid", Member = "UpdateServerBaseline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RecycleTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateCurrentFrame", ReturnType = typeof(void))]
		[CalledBy(Type = "LTDescr", Member = "updateInternal", ReturnType = typeof(bool))]
		[CalledBy(Type = "LTDescr", Member = "init", ReturnType = typeof(void))]
		[CalledBy(Type = "LTGUI", Member = "hasNoOverlap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "LeanTween", Member = "update", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RefreshCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
		[CallerCount(Count = 21)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000ADA")]
		 get { } //Length: 42
	}

	[NativeProperty("Realtime")]
	[Token(Token = "0x170001CA")]
	public static float realtimeSinceStartup
	{
		[Address(RVA = "0x1971770", Offset = "0x1970970", Length = "0x2A")]
		[CallerCount(Count = 28)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000ADC")]
		 get { } //Length: 42
	}

	[NativeProperty("Realtime")]
	[Token(Token = "0x170001CB")]
	public static double realtimeSinceStartupAsDouble
	{
		[Address(RVA = "0x1971740", Offset = "0x1970940", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000ADD")]
		 get { } //Length: 42
	}

	[NativeProperty("RenderFrameCount")]
	[Token(Token = "0x170001C9")]
	public static int renderedFrameCount
	{
		[Address(RVA = "0x19717A0", Offset = "0x19709A0", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.SplineParameter", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.ParameterOverride"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.SplineParameter", Member = "Interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.Spline", "UnityEngine.Rendering.PostProcessing.Spline", typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000ADB")]
		 get { } //Length: 42
	}

	[NativeProperty("CurTime")]
	[Token(Token = "0x170001BE")]
	public static float time
	{
		[Address(RVA = "0x19718E0", Offset = "0x1970AE0", Length = "0x2A")]
		[CalledBy(Type = "Mirror.NetworkClient", Member = "UnpackAndInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "RLD.InputDeviceBase", Member = "Update", ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.InputDeviceBase", Member = "DetectAndHandleDoubleTap", ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Game+<WaitForGameLoad>d__29", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.DynValue", "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkConnection", Member = ".ctor", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkConnection", Member = "IsAlive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.NetworkServer", Member = "UnpackAndInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkConnectionToClient", "Mirror.NetworkReader", typeof(int)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.NetworkServer", Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SendVelocity", ReturnType = typeof(void))]
		[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Update", ReturnType = typeof(void))]
		[CallerCount(Count = 24)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD0")]
		 get { } //Length: 42
	}

	[NativeProperty("CurTime")]
	[Token(Token = "0x170001BF")]
	public static double timeAsDouble
	{
		[Address(RVA = "0x19717D0", Offset = "0x19709D0", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD1")]
		 get { } //Length: 42
	}

	[NativeProperty("CurTimeRational")]
	[Token(Token = "0x170001C0")]
	public static RationalTime timeAsRational
	{
		[Address(RVA = "0x1971840", Offset = "0x1970A40", Length = "0x3C")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "GetTimestamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(DiscreteTime))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.KeyEvent")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.CommandEvent")]
		[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Time", Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD2")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170001C7")]
	public static float timeScale
	{
		[Address(RVA = "0x1971880", Offset = "0x1970A80", Length = "0x2A")]
		[CalledBy(Type = "UnityEngine.AudioSource", Member = "PlayClipAtPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AudioClip", typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD9")]
		 get { } //Length: 42
	}

	[NativeProperty("TimeSinceSceneLoad")]
	[Token(Token = "0x170001C1")]
	public static float timeSinceLevelLoad
	{
		[Address(RVA = "0x19718B0", Offset = "0x1970AB0", Length = "0x2A")]
		[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "GameTime", ReturnType = typeof(float))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD3")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001C5")]
	public static float unscaledDeltaTime
	{
		[Address(RVA = "0x1971910", Offset = "0x1970B10", Length = "0x2A")]
		[CalledBy(Type = "LeanTween", Member = "update", ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Button+<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
		[CalledBy(Type = "Mirror.NetworkClient", Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkClient", Member = "UpdateTimeInterpolation", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkConnectionToClient", Member = "UpdateTimeInterpolation", ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD7")]
		 get { } //Length: 42
	}

	[Token(Token = "0x170001C3")]
	public static float unscaledTime
	{
		[Address(RVA = "0x1971970", Offset = "0x1970B70", Length = "0x2A")]
		[CallerCount(Count = 30)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD5")]
		 get { } //Length: 42
	}

	[NativeProperty("UnscaledTime")]
	[Token(Token = "0x170001C4")]
	public static double unscaledTimeAsDouble
	{
		[Address(RVA = "0x1971940", Offset = "0x1970B40", Length = "0x2A")]
		[CallerCount(Count = 94)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000AD6")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x19716B0", Offset = "0x19708B0", Length = "0x2A")]
	[CallerCount(Count = 91)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD4")]
	public static float get_deltaTime() { }

	[Address(RVA = "0x19716E0", Offset = "0x19708E0", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.BaseScript", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Camera", Member = "ApplyCameraTransform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Transform)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Player", Member = "Move", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkLerpRigidbody", Member = "FixedUpdate", ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD8")]
	public static float get_fixedDeltaTime() { }

	[Address(RVA = "0x1971710", Offset = "0x1970910", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RefreshCaching", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "LeanTween", Member = "update", ReturnType = typeof(void))]
	[CalledBy(Type = "LTGUI", Member = "hasNoOverlap", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "LTDescr", Member = "init", ReturnType = typeof(void))]
	[CalledBy(Type = "LTDescr", Member = "updateInternal", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandle", Member = "UpdateCurrentFrame", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "RecycleTextInfoFromCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "AddTextInfoToCache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.TextCore.Text.TextHandle", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkBehaviourHybrid", Member = "UpdateServerBaseline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkBehaviourHybrid", Member = "UpdateClientBaseline", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkBehaviourHybrid", Member = "OnSerialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkServer", Member = "SerializeForConnection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkIdentity", "Mirror.NetworkConnectionToClient"}, ReturnType = "Mirror.NetworkWriter")]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "UpdateGhosting", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "UpdateState", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.TextCore.Text.TextHandleTemporaryCache", Member = "UpdateCurrentFrame", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.PredictedRigidbody", Member = "Update", ReturnType = typeof(void))]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ADA")]
	public static int get_frameCount() { }

	[Address(RVA = "0x1971770", Offset = "0x1970970", Length = "0x2A")]
	[CallerCount(Count = 28)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ADC")]
	public static float get_realtimeSinceStartup() { }

	[Address(RVA = "0x1971740", Offset = "0x1970940", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ADD")]
	public static double get_realtimeSinceStartupAsDouble() { }

	[Address(RVA = "0x19717A0", Offset = "0x19709A0", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.SplineParameter", Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.ParameterOverride"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.SplineParameter", Member = "Interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Rendering.PostProcessing.Spline", "UnityEngine.Rendering.PostProcessing.Spline", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.Rendering.PostProcessing.Spline", Member = "Cache", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ADB")]
	public static int get_renderedFrameCount() { }

	[Address(RVA = "0x19718E0", Offset = "0x1970AE0", Length = "0x2A")]
	[CalledBy(Type = "Battlehub.UIControls.VirtualizingItemsControl", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.Experimental.NetworkRigidbody2D", Member = "SendVelocity", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkServer", Member = "OnTransportData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.ArraySegment`1<Byte>", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkServer", Member = "UnpackAndInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkConnectionToClient", "Mirror.NetworkReader", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkConnection", Member = "IsAlive", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Set", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.DynValue", "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkConnection", Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Deserialize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Datamodel.Game+<WaitForGameLoad>d__29", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "RLD.InputDeviceBase", Member = "DetectAndHandleDoubleTap", ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.InputDeviceBase", Member = "Update", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "UnpackAndInvoke", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader", typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Datamodel.Services.Datastore", Member = "Get", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "MoonSharp.Interpreter.DynValue"}, ReturnType = typeof(void))]
	[CallerCount(Count = 24)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD0")]
	public static float get_time() { }

	[Address(RVA = "0x19717D0", Offset = "0x19709D0", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD1")]
	public static double get_timeAsDouble() { }

	[Address(RVA = "0x1971840", Offset = "0x1970A40", Length = "0x3C")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "GetTimestamp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(DiscreteTime))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToKeyEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.KeyEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToTextInputEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.TextInputEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "SendNextOrPreviousNavigationEventOnTabKeyDownEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.InputForUI.InputEventPartialProvider", Member = "ToCommandEvent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Event&"}, ReturnType = "UnityEngine.InputForUI.CommandEvent")]
	[CalledBy(Type = "UnityEngine.InputForUI.InputManagerProvider+Time", Member = "get_timeAsRational", ReturnType = typeof(RationalTime))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD2")]
	public static RationalTime get_timeAsRational() { }

	[Address(RVA = "0x1971800", Offset = "0x1970A00", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000ADE")]
	private static void get_timeAsRational_Injected(out RationalTime ret) { }

	[Address(RVA = "0x1971880", Offset = "0x1970A80", Length = "0x2A")]
	[CalledBy(Type = "UnityEngine.AudioSource", Member = "PlayClipAtPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.AudioClip", typeof(Vector3), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD9")]
	public static float get_timeScale() { }

	[Address(RVA = "0x19718B0", Offset = "0x1970AB0", Length = "0x2A")]
	[CalledBy(Type = "Polytoria.Datamodel.Services.ScriptService", Member = "GameTime", ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD3")]
	public static float get_timeSinceLevelLoad() { }

	[Address(RVA = "0x1971910", Offset = "0x1970B10", Length = "0x2A")]
	[CalledBy(Type = "LeanTween", Member = "update", ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Button+<OnFinishSubmit>d__9", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1+<Start>d__2", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "NetworkEarlyUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkClient", Member = "UpdateTimeInterpolation", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkConnectionToClient", Member = "UpdateTimeInterpolation", ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD7")]
	public static float get_unscaledDeltaTime() { }

	[Address(RVA = "0x1971970", Offset = "0x1970B70", Length = "0x2A")]
	[CallerCount(Count = 30)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD5")]
	public static float get_unscaledTime() { }

	[Address(RVA = "0x1971940", Offset = "0x1970B40", Length = "0x2A")]
	[CallerCount(Count = 94)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000AD6")]
	public static double get_unscaledTimeAsDouble() { }

}

