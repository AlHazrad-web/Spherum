using UnityEngine;
public class ParticlesController : MonoBehaviour {

    public Transform target;
    private ParticleSystem particles;
    private ParticleSystem.Particle[] particleBuffer;

    private void Start() {
        particles = GetComponent<ParticleSystem>();
        particleBuffer = new ParticleSystem.Particle[particles.main.maxParticles];
    }

    void Update() {
        int numParticlesAlive = particles.GetParticles(particleBuffer);
        for (int i = 0; i < numParticlesAlive; i++) {
            ParticleSystem.Particle particle = particleBuffer[i];

            Vector3 direction = target.position - particle.position;
            particle.velocity = direction.normalized * particle.velocity.magnitude;

            particleBuffer[i] = particle;
        }

        particles.SetParticles(particleBuffer, numParticlesAlive);
    }

}
