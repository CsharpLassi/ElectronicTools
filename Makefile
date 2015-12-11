BUILD = bin/

TARGET = CSElectronicTools



all: $(BUILD)$(TARGET)

rebuild: all

$(BUILD)$(TARGET): $(BUILD) $(shell find ./$(TARGET) -path obj -prune -o -name '*.cs')
	echo $+
	mcs -target:library -out:$@.dll $(shell find ./$(TARGET) -path obj -prune -o -name '*.cs')

$(BUILD):
	mkdir $@

