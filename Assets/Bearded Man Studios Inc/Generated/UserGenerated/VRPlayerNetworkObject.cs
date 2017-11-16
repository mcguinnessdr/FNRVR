using BeardedManStudios.Forge.Networking.Frame;
using BeardedManStudios.Forge.Networking.Unity;
using System;
using UnityEngine;

namespace BeardedManStudios.Forge.Networking.Generated
{
	[GeneratedInterpol("{\"inter\":[0,0,0,0,0,0]")]
	public partial class VRPlayerNetworkObject : NetworkObject
	{
		public const int IDENTITY = 6;

		private byte[] _dirtyFields = new byte[1];

		#pragma warning disable 0067
		public event FieldChangedEvent fieldAltered;
		#pragma warning restore 0067
		private Vector3 _HeadsetPosition;
		public event FieldEvent<Vector3> HeadsetPositionChanged;
		public InterpolateVector3 HeadsetPositionInterpolation = new InterpolateVector3() { LerpT = 0f, Enabled = false };
		public Vector3 HeadsetPosition
		{
			get { return _HeadsetPosition; }
			set
			{
				// Don't do anything if the value is the same
				if (_HeadsetPosition == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x1;
				_HeadsetPosition = value;
				hasDirtyFields = true;
			}
		}

		public void SetHeadsetPositionDirty()
		{
			_dirtyFields[0] |= 0x1;
			hasDirtyFields = true;
		}

		private void RunChange_HeadsetPosition(ulong timestep)
		{
			if (HeadsetPositionChanged != null) HeadsetPositionChanged(_HeadsetPosition, timestep);
			if (fieldAltered != null) fieldAltered("HeadsetPosition", _HeadsetPosition, timestep);
		}
		private Quaternion _HeadsetRotation;
		public event FieldEvent<Quaternion> HeadsetRotationChanged;
		public InterpolateQuaternion HeadsetRotationInterpolation = new InterpolateQuaternion() { LerpT = 0f, Enabled = false };
		public Quaternion HeadsetRotation
		{
			get { return _HeadsetRotation; }
			set
			{
				// Don't do anything if the value is the same
				if (_HeadsetRotation == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x2;
				_HeadsetRotation = value;
				hasDirtyFields = true;
			}
		}

		public void SetHeadsetRotationDirty()
		{
			_dirtyFields[0] |= 0x2;
			hasDirtyFields = true;
		}

		private void RunChange_HeadsetRotation(ulong timestep)
		{
			if (HeadsetRotationChanged != null) HeadsetRotationChanged(_HeadsetRotation, timestep);
			if (fieldAltered != null) fieldAltered("HeadsetRotation", _HeadsetRotation, timestep);
		}
		private Vector3 _LeftControllerPosition;
		public event FieldEvent<Vector3> LeftControllerPositionChanged;
		public InterpolateVector3 LeftControllerPositionInterpolation = new InterpolateVector3() { LerpT = 0f, Enabled = false };
		public Vector3 LeftControllerPosition
		{
			get { return _LeftControllerPosition; }
			set
			{
				// Don't do anything if the value is the same
				if (_LeftControllerPosition == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x4;
				_LeftControllerPosition = value;
				hasDirtyFields = true;
			}
		}

		public void SetLeftControllerPositionDirty()
		{
			_dirtyFields[0] |= 0x4;
			hasDirtyFields = true;
		}

		private void RunChange_LeftControllerPosition(ulong timestep)
		{
			if (LeftControllerPositionChanged != null) LeftControllerPositionChanged(_LeftControllerPosition, timestep);
			if (fieldAltered != null) fieldAltered("LeftControllerPosition", _LeftControllerPosition, timestep);
		}
		private Quaternion _LeftControllerRotation;
		public event FieldEvent<Quaternion> LeftControllerRotationChanged;
		public InterpolateQuaternion LeftControllerRotationInterpolation = new InterpolateQuaternion() { LerpT = 0f, Enabled = false };
		public Quaternion LeftControllerRotation
		{
			get { return _LeftControllerRotation; }
			set
			{
				// Don't do anything if the value is the same
				if (_LeftControllerRotation == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x8;
				_LeftControllerRotation = value;
				hasDirtyFields = true;
			}
		}

		public void SetLeftControllerRotationDirty()
		{
			_dirtyFields[0] |= 0x8;
			hasDirtyFields = true;
		}

		private void RunChange_LeftControllerRotation(ulong timestep)
		{
			if (LeftControllerRotationChanged != null) LeftControllerRotationChanged(_LeftControllerRotation, timestep);
			if (fieldAltered != null) fieldAltered("LeftControllerRotation", _LeftControllerRotation, timestep);
		}
		private Vector3 _RightControllerPosition;
		public event FieldEvent<Vector3> RightControllerPositionChanged;
		public InterpolateVector3 RightControllerPositionInterpolation = new InterpolateVector3() { LerpT = 0f, Enabled = false };
		public Vector3 RightControllerPosition
		{
			get { return _RightControllerPosition; }
			set
			{
				// Don't do anything if the value is the same
				if (_RightControllerPosition == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x10;
				_RightControllerPosition = value;
				hasDirtyFields = true;
			}
		}

		public void SetRightControllerPositionDirty()
		{
			_dirtyFields[0] |= 0x10;
			hasDirtyFields = true;
		}

		private void RunChange_RightControllerPosition(ulong timestep)
		{
			if (RightControllerPositionChanged != null) RightControllerPositionChanged(_RightControllerPosition, timestep);
			if (fieldAltered != null) fieldAltered("RightControllerPosition", _RightControllerPosition, timestep);
		}
		private Quaternion _RightControllerRotation;
		public event FieldEvent<Quaternion> RightControllerRotationChanged;
		public InterpolateQuaternion RightControllerRotationInterpolation = new InterpolateQuaternion() { LerpT = 0f, Enabled = false };
		public Quaternion RightControllerRotation
		{
			get { return _RightControllerRotation; }
			set
			{
				// Don't do anything if the value is the same
				if (_RightControllerRotation == value)
					return;

				// Mark the field as dirty for the network to transmit
				_dirtyFields[0] |= 0x20;
				_RightControllerRotation = value;
				hasDirtyFields = true;
			}
		}

		public void SetRightControllerRotationDirty()
		{
			_dirtyFields[0] |= 0x20;
			hasDirtyFields = true;
		}

		private void RunChange_RightControllerRotation(ulong timestep)
		{
			if (RightControllerRotationChanged != null) RightControllerRotationChanged(_RightControllerRotation, timestep);
			if (fieldAltered != null) fieldAltered("RightControllerRotation", _RightControllerRotation, timestep);
		}

		protected override void OwnershipChanged()
		{
			base.OwnershipChanged();
			SnapInterpolations();
		}
		
		public void SnapInterpolations()
		{
			HeadsetPositionInterpolation.current = HeadsetPositionInterpolation.target;
			HeadsetRotationInterpolation.current = HeadsetRotationInterpolation.target;
			LeftControllerPositionInterpolation.current = LeftControllerPositionInterpolation.target;
			LeftControllerRotationInterpolation.current = LeftControllerRotationInterpolation.target;
			RightControllerPositionInterpolation.current = RightControllerPositionInterpolation.target;
			RightControllerRotationInterpolation.current = RightControllerRotationInterpolation.target;
		}

		public override int UniqueIdentity { get { return IDENTITY; } }

		protected override BMSByte WritePayload(BMSByte data)
		{
			UnityObjectMapper.Instance.MapBytes(data, _HeadsetPosition);
			UnityObjectMapper.Instance.MapBytes(data, _HeadsetRotation);
			UnityObjectMapper.Instance.MapBytes(data, _LeftControllerPosition);
			UnityObjectMapper.Instance.MapBytes(data, _LeftControllerRotation);
			UnityObjectMapper.Instance.MapBytes(data, _RightControllerPosition);
			UnityObjectMapper.Instance.MapBytes(data, _RightControllerRotation);

			return data;
		}

		protected override void ReadPayload(BMSByte payload, ulong timestep)
		{
			_HeadsetPosition = UnityObjectMapper.Instance.Map<Vector3>(payload);
			HeadsetPositionInterpolation.current = _HeadsetPosition;
			HeadsetPositionInterpolation.target = _HeadsetPosition;
			RunChange_HeadsetPosition(timestep);
			_HeadsetRotation = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			HeadsetRotationInterpolation.current = _HeadsetRotation;
			HeadsetRotationInterpolation.target = _HeadsetRotation;
			RunChange_HeadsetRotation(timestep);
			_LeftControllerPosition = UnityObjectMapper.Instance.Map<Vector3>(payload);
			LeftControllerPositionInterpolation.current = _LeftControllerPosition;
			LeftControllerPositionInterpolation.target = _LeftControllerPosition;
			RunChange_LeftControllerPosition(timestep);
			_LeftControllerRotation = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			LeftControllerRotationInterpolation.current = _LeftControllerRotation;
			LeftControllerRotationInterpolation.target = _LeftControllerRotation;
			RunChange_LeftControllerRotation(timestep);
			_RightControllerPosition = UnityObjectMapper.Instance.Map<Vector3>(payload);
			RightControllerPositionInterpolation.current = _RightControllerPosition;
			RightControllerPositionInterpolation.target = _RightControllerPosition;
			RunChange_RightControllerPosition(timestep);
			_RightControllerRotation = UnityObjectMapper.Instance.Map<Quaternion>(payload);
			RightControllerRotationInterpolation.current = _RightControllerRotation;
			RightControllerRotationInterpolation.target = _RightControllerRotation;
			RunChange_RightControllerRotation(timestep);
		}

		protected override BMSByte SerializeDirtyFields()
		{
			dirtyFieldsData.Clear();
			dirtyFieldsData.Append(_dirtyFields);

			if ((0x1 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _HeadsetPosition);
			if ((0x2 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _HeadsetRotation);
			if ((0x4 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _LeftControllerPosition);
			if ((0x8 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _LeftControllerRotation);
			if ((0x10 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _RightControllerPosition);
			if ((0x20 & _dirtyFields[0]) != 0)
				UnityObjectMapper.Instance.MapBytes(dirtyFieldsData, _RightControllerRotation);

			// Reset all the dirty fields
			for (int i = 0; i < _dirtyFields.Length; i++)
				_dirtyFields[i] = 0;

			return dirtyFieldsData;
		}

		protected override void ReadDirtyFields(BMSByte data, ulong timestep)
		{
			if (readDirtyFlags == null)
				Initialize();

			Buffer.BlockCopy(data.byteArr, data.StartIndex(), readDirtyFlags, 0, readDirtyFlags.Length);
			data.MoveStartIndex(readDirtyFlags.Length);

			if ((0x1 & readDirtyFlags[0]) != 0)
			{
				if (HeadsetPositionInterpolation.Enabled)
				{
					HeadsetPositionInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					HeadsetPositionInterpolation.Timestep = timestep;
				}
				else
				{
					_HeadsetPosition = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_HeadsetPosition(timestep);
				}
			}
			if ((0x2 & readDirtyFlags[0]) != 0)
			{
				if (HeadsetRotationInterpolation.Enabled)
				{
					HeadsetRotationInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					HeadsetRotationInterpolation.Timestep = timestep;
				}
				else
				{
					_HeadsetRotation = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_HeadsetRotation(timestep);
				}
			}
			if ((0x4 & readDirtyFlags[0]) != 0)
			{
				if (LeftControllerPositionInterpolation.Enabled)
				{
					LeftControllerPositionInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					LeftControllerPositionInterpolation.Timestep = timestep;
				}
				else
				{
					_LeftControllerPosition = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_LeftControllerPosition(timestep);
				}
			}
			if ((0x8 & readDirtyFlags[0]) != 0)
			{
				if (LeftControllerRotationInterpolation.Enabled)
				{
					LeftControllerRotationInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					LeftControllerRotationInterpolation.Timestep = timestep;
				}
				else
				{
					_LeftControllerRotation = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_LeftControllerRotation(timestep);
				}
			}
			if ((0x10 & readDirtyFlags[0]) != 0)
			{
				if (RightControllerPositionInterpolation.Enabled)
				{
					RightControllerPositionInterpolation.target = UnityObjectMapper.Instance.Map<Vector3>(data);
					RightControllerPositionInterpolation.Timestep = timestep;
				}
				else
				{
					_RightControllerPosition = UnityObjectMapper.Instance.Map<Vector3>(data);
					RunChange_RightControllerPosition(timestep);
				}
			}
			if ((0x20 & readDirtyFlags[0]) != 0)
			{
				if (RightControllerRotationInterpolation.Enabled)
				{
					RightControllerRotationInterpolation.target = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RightControllerRotationInterpolation.Timestep = timestep;
				}
				else
				{
					_RightControllerRotation = UnityObjectMapper.Instance.Map<Quaternion>(data);
					RunChange_RightControllerRotation(timestep);
				}
			}
		}

		public override void InterpolateUpdate()
		{
			if (IsOwner)
				return;

			if (HeadsetPositionInterpolation.Enabled && !HeadsetPositionInterpolation.current.UnityNear(HeadsetPositionInterpolation.target, 0.0015f))
			{
				_HeadsetPosition = (Vector3)HeadsetPositionInterpolation.Interpolate();
				//RunChange_HeadsetPosition(HeadsetPositionInterpolation.Timestep);
			}
			if (HeadsetRotationInterpolation.Enabled && !HeadsetRotationInterpolation.current.UnityNear(HeadsetRotationInterpolation.target, 0.0015f))
			{
				_HeadsetRotation = (Quaternion)HeadsetRotationInterpolation.Interpolate();
				//RunChange_HeadsetRotation(HeadsetRotationInterpolation.Timestep);
			}
			if (LeftControllerPositionInterpolation.Enabled && !LeftControllerPositionInterpolation.current.UnityNear(LeftControllerPositionInterpolation.target, 0.0015f))
			{
				_LeftControllerPosition = (Vector3)LeftControllerPositionInterpolation.Interpolate();
				//RunChange_LeftControllerPosition(LeftControllerPositionInterpolation.Timestep);
			}
			if (LeftControllerRotationInterpolation.Enabled && !LeftControllerRotationInterpolation.current.UnityNear(LeftControllerRotationInterpolation.target, 0.0015f))
			{
				_LeftControllerRotation = (Quaternion)LeftControllerRotationInterpolation.Interpolate();
				//RunChange_LeftControllerRotation(LeftControllerRotationInterpolation.Timestep);
			}
			if (RightControllerPositionInterpolation.Enabled && !RightControllerPositionInterpolation.current.UnityNear(RightControllerPositionInterpolation.target, 0.0015f))
			{
				_RightControllerPosition = (Vector3)RightControllerPositionInterpolation.Interpolate();
				//RunChange_RightControllerPosition(RightControllerPositionInterpolation.Timestep);
			}
			if (RightControllerRotationInterpolation.Enabled && !RightControllerRotationInterpolation.current.UnityNear(RightControllerRotationInterpolation.target, 0.0015f))
			{
				_RightControllerRotation = (Quaternion)RightControllerRotationInterpolation.Interpolate();
				//RunChange_RightControllerRotation(RightControllerRotationInterpolation.Timestep);
			}
		}

		private void Initialize()
		{
			if (readDirtyFlags == null)
				readDirtyFlags = new byte[1];

		}

		public VRPlayerNetworkObject() : base() { Initialize(); }
		public VRPlayerNetworkObject(NetWorker networker, INetworkBehavior networkBehavior = null, int createCode = 0, byte[] metadata = null) : base(networker, networkBehavior, createCode, metadata) { Initialize(); }
		public VRPlayerNetworkObject(NetWorker networker, uint serverId, FrameStream frame) : base(networker, serverId, frame) { Initialize(); }

		// DO NOT TOUCH, THIS GETS GENERATED PLEASE EXTEND THIS CLASS IF YOU WISH TO HAVE CUSTOM CODE ADDITIONS
	}
}
