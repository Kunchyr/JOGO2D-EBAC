using System.Collections;
using UnityEngine;

public class GunBase : MonoBehaviour
{
    public ProjectileBase projectilePrefab;
    public Transform shootPoint;
    public Transform PlayerSide;
    public float shootRate = 0.5f;
    private Coroutine _currentCoroutine;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            _currentCoroutine = StartCoroutine(StartShoot());
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if(_currentCoroutine != null)
            {
                StopCoroutine(_currentCoroutine);
            }
        }
    }
    IEnumerator StartShoot()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(shootRate);
        }
    }
    private void Shoot()
    {
    var projectile = Instantiate(projectilePrefab);
        projectile.transform.position = shootPoint.position;
        projectile.direction = new Vector3(PlayerSide.transform.localScale.x * -1, 0, 0);
    }
    
}
