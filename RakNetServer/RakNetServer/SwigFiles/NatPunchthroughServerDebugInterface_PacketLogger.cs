//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace RakNet {

public class NatPunchthroughServerDebugInterface_PacketLogger : NatPunchthroughServerDebugInterface {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal NatPunchthroughServerDebugInterface_PacketLogger(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.CSharp_RakNet_NatPunchthroughServerDebugInterface_PacketLogger_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(NatPunchthroughServerDebugInterface_PacketLogger obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~NatPunchthroughServerDebugInterface_PacketLogger() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.CSharp_RakNet_delete_NatPunchthroughServerDebugInterface_PacketLogger(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public PacketLogger pl {
    set {
      RakNetPINVOKE.CSharp_RakNet_NatPunchthroughServerDebugInterface_PacketLogger_pl_set(swigCPtr, PacketLogger.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = RakNetPINVOKE.CSharp_RakNet_NatPunchthroughServerDebugInterface_PacketLogger_pl_get(swigCPtr);
      PacketLogger ret = (cPtr == global::System.IntPtr.Zero) ? null : new PacketLogger(cPtr, false);
      return ret;
    } 
  }

  public NatPunchthroughServerDebugInterface_PacketLogger() : this(RakNetPINVOKE.CSharp_RakNet_new_NatPunchthroughServerDebugInterface_PacketLogger(), true) {
  }

  public override void OnServerMessage(string msg) {
    RakNetPINVOKE.CSharp_RakNet_NatPunchthroughServerDebugInterface_PacketLogger_OnServerMessage(swigCPtr, msg);
  }

}

}
