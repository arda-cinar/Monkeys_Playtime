# Echoes of the Toy
### Unity ile Geliştirilmiş FPS Psikolojik Korku Oyunu
**(Proje Kod Adı: Monkeys_Playtime)**

<img width="2528" height="1696" alt="Gemini_Generated_Image_yrwfhgyrwfhgyrwf" src="https://github.com/user-attachments/assets/e9b445ba-effb-4b0c-9acc-5ee04c875db4" />

## Proje Hakkında
Unity oyun motoru kullanılarak geliştirilen **Echoes of the Toy**, FPS (Birinci Şahıs) bakış açısına sahip, atmosfer odaklı bir psikolojik korku oyunudur. Günümüz korku oyunlarında (2025) hissedilen "nitelikli ve hikaye derinliği olan yapım" eksikliğini giderme vizyonuyla ortaya çıkan bu çalışma, *Silent Hill 4* ve *Layers of Fear (2016)* gibi klasiklerin yarattığı tekinsiz atmosferden ilham almaktadır.

## Oynanış ve Hikaye Kurgusu
Oyun, oyuncuyu sadece anlık korku öğeleriyle (jumpscare) değil, "beklenti gerilimi" ile huzursuz etmeyi amaçlar. Sıradan görünen bir ev ortamında geçen hikayede, ana karakter hem paranormal olaylarla hem de kendi iç dünyasındaki duygusal karmaşayla yüzleşir. Oyunun temel tehdidi, evin içinde nadiren ortaya çıkan ancak görüldüğünde ölümcül bir kovalamacayı başlatan robotik bir varlıktır. Sinematik anlatım teknikleri ve çevresel hikaye anlatıcılığı ile desteklenen yapım, oyuncuya sadece bir kaçış serüveni değil, aynı zamanda sanatsal ve psikolojik bir deneyim sunmayı hedefler.

## Teknik Altyapı ve Geliştirme Süreci
Bu proje, Unity motorunun fizik ve etkileşim sistemlerinin aktif kullanıldığı bir yazılım projesidir. Geliştirme sürecinde aşağıdaki yapılar kullanılmıştır:

* **Karakter Kontrolcüsü (Character Controller):** Unity'nin fizik motorundan bağımsız, stabil bir hareket mekaniği için özel CharacterController yapısı kodlanmıştır. Yerçekimi simülasyonu ve zemin algılama (Ground Check) algoritmaları manuel olarak hesaplanmaktadır.
* **Kamera Mekaniği:** FPS bakış açısında gerçekçiliği sağlamak için dikey eksende (Y-Axis) kilitlenme (Clamping) uygulanarak görüş açısı sınırlandırılmıştır.
* **Tetikleyici Tabanlı Etkileşim:** Çevredeki objelerle (kapılar vb.) etkileşime girmek için fiziksel temas gerektirmeyen, tetikleyici alanlar (Trigger Box) ve tuş girdisi (E Key) ile çalışan bir etkileşim mantığı kurgulanmıştır.
* **Kare Hızından Bağımsız Hareket:** Tüm hareket ve fizik hesaplamaları Time.deltaTime kullanılarak normalize edilmiş, böylece oyunun farklı performanslardaki bilgisayarlarda aynı hızda çalışması sağlanmıştır.

---

## English Summary

### About the Project
Developed using the Unity game engine, **Echoes of the Toy** is a first-person psychological horror game focused on atmosphere and narrative depth. Inspired by classics like *Silent Hill 4* and *Layers of Fear (2016)*, it aims to fill the gap of high-quality horror experiences in the current market.

### Gameplay & Narrative
Rather than relying solely on cheap jumpscares, the game builds tension through paranoia and anticipation. Set in a seemingly ordinary house, the protagonist faces paranormal anomalies and a haunting robotic entity that triggers intense chase sequences. By blending cinematic storytelling with psychological horror elements, the game offers players not just an escape mission, but an emotional journey into the character's internal conflict.

### Technical Development Process
This project utilizes various Unity systems to ensure a professional and stable gameplay experience:
* **Character Controller:** A custom CharacterController structure has been implemented for precise movement mechanics independent of the built-in physics engine. Gravity and ground-checking algorithms are manually calculated.
* **Camera Mechanics:** Vertical rotation (Y-Axis) is mathematically restricted to ensure a realistic FPS perspective.
* **Trigger-Based Interaction:** Environmental interactions, such as opening doors, are handled through Trigger Colliders and input detection (E key).
* **Frame-rate Independence:** All movement calculations are normalized using Time.deltaTime to ensure consistent speed across different hardware performance levels.
