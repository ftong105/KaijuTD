using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    public GameObject playerCam;
    public float range = 40f;
    public float gDamage = 33f;
    public float fireRate = 4f;
    private float nextTimeToFire = 0f;
    public Text ammo;

    public AudioClip shotAudio;
    public AudioSource audioSource;
    public AudioMixerGroup mixer;

    public int maxAmmo = 10;
    private int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloading = false;

    public Animator playerAnimator;

    private void Start()
    {
        currentAmmo = maxAmmo;

        InstantiateAudio(shotAudio);

        audioSource.outputAudioMixerGroup = mixer;
    }

    private void InstantiateAudio(AudioClip clip)
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
    }

    private void OnEnable()
    {
        isReloading = false;
        playerAnimator.SetBool("isReloading", false);
    }

    private void Update()
    {
        if (isReloading)
        {
            return;
        }

        if (currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            //return;
        }

        if (playerAnimator.GetBool("isShooting"))
        {
            playerAnimator.SetBool("isShooting", false);
        }

        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && currentAmmo >= 0)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.R) && currentAmmo < maxAmmo)
        {
            StartCoroutine(Reload());
        }


        ammo.text = currentAmmo.ToString() + " / ¡Þ";
    }

    public void Shoot()
    {
        playerAnimator.SetBool("isShooting", true);

        RaycastHit ray;

        //Checking if raycast hit any object, if it hits information is passed to the ray variable 
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out ray, range))
        {
            //Trying to get EmemyManager componenet from the hit object
            EnemyManager enemyManager = ray.transform.GetComponent<EnemyManager>();
            if (enemyManager != null) //only if we find the target
            {
                enemyManager.Hit(gDamage);
                //Debug.Log("hit");
            }
        }

        currentAmmo--;
    }

    IEnumerator Reload()
    {
        isReloading = true;
        playerAnimator.SetBool("isReloading", true);

        yield return new WaitForSeconds(reloadTime - 0.25f);
        playerAnimator.SetBool("isReloading", false);
        yield return new WaitForSeconds(0.25f);
        currentAmmo = maxAmmo;
        isReloading = false;
    }

    /*private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, range);
    }*/
}
