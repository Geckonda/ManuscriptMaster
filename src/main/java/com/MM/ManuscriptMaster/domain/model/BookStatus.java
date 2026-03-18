package com.MM.ManuscriptMaster.domain.model;

import lombok.AllArgsConstructor;
import lombok.Getter;

@AllArgsConstructor
@Getter
public enum BookStatus {
    IN_PROCESS("В процессе"),
    Finished("Завершен"),
    Freezed("Заморожен"),
    Abandoned("Заброшен");

    private final String displayNamee;
}
