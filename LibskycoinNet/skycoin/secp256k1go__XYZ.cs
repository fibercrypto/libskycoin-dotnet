//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace skycoin {

public class secp256k1go__XYZ : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal secp256k1go__XYZ(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(secp256k1go__XYZ obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~secp256k1go__XYZ() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          skycoinPINVOKE.delete_secp256k1go__XYZ(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public secp256k1go__Field X {
    set {
      skycoinPINVOKE.set_secp256k1go__XYZ_X(swigCPtr, secp256k1go__Field.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.get_secp256k1go__XYZ_X(swigCPtr);
      secp256k1go__Field ret = (cPtr == global::System.IntPtr.Zero) ? null : new secp256k1go__Field(cPtr, false);
      return ret;
    } 
  }

  public secp256k1go__Field Y {
    set {
      skycoinPINVOKE.set_secp256k1go__XYZ_Y(swigCPtr, secp256k1go__Field.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.get_secp256k1go__XYZ_Y(swigCPtr);
      secp256k1go__Field ret = (cPtr == global::System.IntPtr.Zero) ? null : new secp256k1go__Field(cPtr, false);
      return ret;
    } 
  }

  public secp256k1go__Field Z {
    set {
      skycoinPINVOKE.set_secp256k1go__XYZ_Z(swigCPtr, secp256k1go__Field.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = skycoinPINVOKE.get_secp256k1go__XYZ_Z(swigCPtr);
      secp256k1go__Field ret = (cPtr == global::System.IntPtr.Zero) ? null : new secp256k1go__Field(cPtr, false);
      return ret;
    } 
  }

  public uint Infinity {
    set {
      skycoinPINVOKE.set_secp256k1go__XYZ_Infinity(swigCPtr, value);
    } 
    get {
      uint ret = skycoinPINVOKE.get_secp256k1go__XYZ_Infinity(swigCPtr);
      return ret;
    } 
  }

  public secp256k1go__XYZ() : this(skycoinPINVOKE.new_secp256k1go__XYZ(), true) {
  }

}

}
