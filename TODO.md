# TODO - Blitz

## Gameplay
- Decide whether `UpdateScore` or `Stopwatch` should be the single score source and remove duplication.
- Add difficulty scaling for obstacle spawn rate and movement speed.
- Add invulnerability or countdown after restart so players are not hit immediately.
- Add pause/resume behavior that consistently freezes spawning and timers.

## Code
- Replace remaining scene-name strings with constants or build-index-safe scene references.
- Remove unused placeholder scripts such as `test.cs` after confirming no scene references it.
- Add null checks or inspector validation for required references like player, score text, and game-over UI.
- Prefer object pooling for obstacles instead of instantiate/destroy during gameplay.

## UI
- Add controls/instructions to the main menu.
- Add final score and best score to the game-over screen.
- Add settings persistence for audio and quality options.

## Project
- Add gameplay screenshots or a short GIF for portfolio display.
- Verify the Unity project opens cleanly in Unity 2022.3.1f1.
- Create a WebGL or Windows build for easier demo sharing.

