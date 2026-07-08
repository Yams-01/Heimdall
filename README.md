# Heimdall

A rule-based process guardian for Windows. Heimdall watches running processes
and enforces access rules in the background, so distracting or unwanted programs
can be blocked automatically.

> **Status:** early stage / work in progress. The architecture is still moving
> and core design may change.

## Concept

Heimdall classifies every running process against a set of user-defined lists
and reacts accordingly:

- **Blacklist** — blocked on sight. The process is terminated whenever it is detected.
- **Orange list** — time-limited. Allowed up to a daily budget, then blocked once the budget is spent.
- **Whitelist** — always allowed. Protects critical system processes so the OS stays stable.

## Tech stack

- **Language:** C# (.NET 10)
- **Core:** cross-platform class library (process enumeration, list model, rule engine)
- **Enforcement:** Windows background service *(planned)*
- **Control panel:** WPF desktop UI *(planned)*

## Roadmap (high level)

- [ ] Enumerate running processes with their real display names
- [ ] List model and persistence (JSON)
- [ ] Rule engine (blacklist / orange list / whitelist)
- [ ] Background enforcement service
- [ ] Control panel UI

## License

This project is **source-available, not open-source**. The code is published for
viewing and academic evaluation only. All rights are reserved — see [LICENSE](LICENSE).

---

*Built by Samy Smail.*
