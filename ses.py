from gtts import gTTS
import os
mytext = 'kare'
language = 'tr'
isim  = 'kare.mp3'
myobj = gTTS(text=mytext, lang=language, slow=False)
myobj.save(isim)
os.system(isim)