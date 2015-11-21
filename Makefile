PLAT = Unix
SRC = Jump.cs JumpSprite.cs Player.cs ILevel.cs Level1.cs GameElements/Block.cs
ifeq ($(PLAT), Unix)
	EXTERN = extern/unix
	FLAGS += -reference:"$(EXTERN)/MonoGame.Framework" -reference:"$(EXTERN)/Tao.Sdl.dll" -g
	POST = cp $(EXTERN)/*.dll .
endif

all: run


run:
	rm Jump.exe || echo "Jump not here"
	mcs $(FLAGS) $(SRC)

	$(POST);
	mono ./Jump.exe
	rm *.dll
