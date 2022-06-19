using System;
using UnityEditor.VersionControl;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
	private WeaponChangeScript _weaponChange;
	private Animator _animator;

	private int _weaponID;

	private void Awake()
	{
		_animator = GetComponent<Animator>();
		_weaponChange = GetComponent<WeaponChangeScript>();
	}

	private void Update()
	{
		WeaponAnimation(_weaponChange.currentWeaponType);
	}

	private void WeaponAnimation(string weapons)
	{
		switch (weapons)
		{
			case "1-Uzi":
				_weaponID = 1;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "2-Shotgun":
				_weaponID = 2;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "3-Magnum":
				_weaponID = 3;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "4-RocketLauncher":
				_weaponID = 4;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "5-Saber":
				_weaponID = 5;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "6-Cricket":
				_weaponID = 6;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "7-NesPistol":
				_weaponID = 7;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "8-SubMachineGun":
				_weaponID = 8;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "9-MachineGun":
				_weaponID = 9;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "10-EnergyPistol":
				_weaponID = 10;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "11-Sniper":
				_weaponID = 11;
				_animator.SetInteger("weaponID", _weaponID);
				break;
			case "12-Punch":
				_weaponID = 12;
				_animator.SetInteger("weaponID", _weaponID);
				break;
		}
	}
	
	public States State
	{
		set => _animator.SetInteger("state", (int)value);
	}
}

public enum States
{
	Idle,
	MoveUp,
	MoveDown
}
