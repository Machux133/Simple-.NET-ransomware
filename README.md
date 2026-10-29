# Simple .NET Ransomware (PoC)

A minimal ransomware proof-of-concept written in C# (WinForms), built as a learning exercise
in offensive security — how this class of malware is structured, not something meant to run
against real targets.

## ⚠️ Purpose and scope

- **Educational only.** This exists to understand ransomware mechanics (file enumeration,
  symmetric encryption, a simple ransom-note UI) for defensive research, malware-analysis
  practice, and coursework.
- **Not a weapon.** There is no dropper, no spreading/propagation logic, and no command-and-control
  channel. It does exactly what the code shows and nothing else.
- **Run it only in an isolated VM or sandbox you control**, disconnected from any network and
  containing no real data. Never run it on a production machine, someone else's system, or
  anything you don't own and fully control.
- The encryption key lives in `EncryptDecrypt.cs` in plaintext — this is intentional, so the
  "attack" is always reversible by the author and never actually destructive.

## Legal note

Creating malware for study/research is one thing; deploying it against systems you don't own
or don't have explicit written authorization to test is a criminal offense in most
jurisdictions (in Poland, see Art. 269b of the Penal Code). You are responsible for how you
use this code.

## What's here

- `Form1.cs` / `Form2.cs` — UI (ransom note, status)
- `EncyrptDecrypt.cs` — symmetric encryption/decryption of target files
- `BGchanger.cs` — swaps the desktop background to display the note
- `DesktopNote.cs` — drops a note file on the desktop

No binaries are published in this repository — source only.
