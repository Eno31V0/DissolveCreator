using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveCreator : MonoBehaviour
{
    [Tooltip("�f�B�]���u�����Ɏg���摜�̍ő�T�C�Y\n��ʑS�̂��M���M���������x�̑傫��������")]
    [SerializeField] float maxSize = 0.0f;
    [Tooltip("�f�B�]���u�����Ɏg���摜�̍ŏ��T�C�Y\n��{�I��0��OK")]
    [SerializeField] float minSize = 0.0f;

    float nowPersent = 0.0f;

    SpriteRenderer m_spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        m_spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (nowPersent >= 1.0f) return;
        nowPersent += 0.003f;
        if (nowPersent > 1.0f) nowPersent = 1.0f;

        transform.localScale = Vector3.Lerp(new Vector3(maxSize, maxSize, maxSize), new Vector3(minSize, minSize, minSize), nowPersent);

        m_spriteRenderer.color = Color.Lerp(Color.black, Color.white, nowPersent);
    }
}
