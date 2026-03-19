using UnityEngine;
using UnityEngine.InputSystem;

public class ShootRay : MonoBehaviour
{
    [SerializeField] private Transform shootPos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    [SerializeField] private GameObject shootVfxPrefab;
    [SerializeField] private GameObject hitVfxPrefab;
    [SerializeField] private int damage;
    void Shoot()
    {
        RaycastHit hit;

        // �Ҵ����������դ������ 30 ˹���
        Debug.DrawRay(shootPos.position, transform.forward * 30, Color.red);

        // �ԧ Ray ��ͧ˹����դ�������٧�ش 30 ˹���
        if (Physics.Raycast(shootPos.position, transform.forward, out hit, 30))
        {
            // �Ҵ�����ᴧ����դ�����Ƕ֧���ѵ�ط�� Ray ��
            Debug.DrawRay(shootPos.position, transform.forward * hit.distance, Color.green);

            // �֧�������ѵ�ط�� Ray �� (�֧����)
            //Debug.Log($"Ray hits: {hit.collider}");

            if (Mouse.current.rightButton.wasPressedThisFrame)
            {
                // �ʡ VFX ���ش�ԧ
                var shootVfx = Instantiate(shootVfxPrefab, shootPos.position, Quaternion.identity, transform);
                // �ʡ VFX ���ش�� / �ԧⴹ���ëѡ���ҧ
                var hitVfx = Instantiate(hitVfxPrefab, hit.point, Quaternion.identity);

                //������ѵ�ط���ʡ�� ����Թҷ�
                Destroy(shootVfx, 3.5f);
                Destroy(hitVfx, 2.5f);

                if (hit.collider.CompareTag("Enemy"))
                {
                    Enemy enemy = hit.collider.GetComponent<Enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamge(damage);
                    }
                }
            }
        }
    }
}
