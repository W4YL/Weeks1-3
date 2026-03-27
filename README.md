# Mechanical Drawing - Guided Projectile System
A code oriented interactive piece simulating guided missile trajectories using linear interpolation and animation curves

## How to Run
1. Clone and open the project in Unity (recommended version: 6000.0.60f1)
2. Open the scene 'Mechanical Drawing'
3. Press play in the Unity Editor

## Key Scripts
- PlayerBehaviour: Checks for player-cursor overlap
- EnemyBehaviour: Linear movement between two reference points
- BulletLerp: Manages bullet reference points' spawn behaviour
- BulletBehaviour: Spawns and moves bullet towards reference points

## What to Look For
- Bullet lerp (reference points)'s spawning logic
- Bullet & Bullet lerp's interpolation logic
- Use of animation curves for movement feel
