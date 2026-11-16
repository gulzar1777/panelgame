# PanelCreate

A small C# Windows Forms game. Create randomly coloured panels and move the bomb to a random position. Each new panel adds one point. If a panel overlaps the bomb, the score resets to zero, and an OK dialog starts a new game.

## Run

1. Extract the ZIP archive.
2. Open `PanelCreate.sln` in Visual Studio on Windows.
3. Use the **.NET desktop development** workload with the **.NET Framework 4.8 targeting pack** installed.
4. Press **F5**.

The bomb image is embedded in the application. This version has no explosion sound. No NuGet packages or file path changes are needed.

## Controls

- **Panel yarat** — create a 60 × 60 panel and add one point.
- **Bombanın yerini dəyiş** — move the bomb randomly.
- **Çıxış** — ask for confirmation and close the application.

Collision uses the rectangular bounds of each panel and the bomb PictureBox. It is checked after either game button is clicked. OK removes all generated panels, restores the bomb's starting position, and starts at zero points.

---

# Azərbaycan dilində

C# Windows Forms ilə hazırlanmış sadə panel və bomba oyunu. Hər yeni panelə görə xal bir vahid artır. Panel bomba ilə toqquşduqda xal sıfırlanır. Bu versiyada bomba səsi yoxdur. Bildirişdə **OK** basıldıqda panellər silinir, bomba başlanğıc mövqeyinə qayıdır və yeni oyun başlayır.

## İşə salmaq

1. ZIP faylını çıxarın.
2. Windows-da Visual Studio ilə `PanelCreate.sln` faylını açın.
3. **.NET desktop development** və **.NET Framework 4.8 targeting pack** quraşdırılmış olmalıdır.
4. **F5** düyməsinə basın.

Bomba şəkli layihəyə daxildir. Fayl yollarını dəyişmək və ya NuGet paketi yükləmək lazım deyil.

## Kodun quruluşu

- `Form1.cs` — düymələrin hadisələri, toqquşma yoxlaması və yeni oyun.
- `Form1.Designer.cs` — formanın və idarəetmə elementlərinin görünüşü.
- `Program.cs` — proqramın başlanğıcı.
- `Resources` — bomba şəkli.

`Bounds.IntersectsWith` iki düzbucaqlı sahənin toqquşmasını yoxlayır. `panel1` aşağıdakı düymələr zolağıdır, buna görə toqquşma yoxlamasından və silinmədən kənarda saxlanılır. Təsadüfi rəng və mövqelər üçün bir `Random` obyekti istifadə olunur.

## GitHub

Arxivi çıxarıb `PanelCreate.sln`, `README.md`, `.gitignore` və `PanelCreate` qovluğunu repozitoriyanın əsas qovluğuna yükləyin. Faylları dəyişmək lazım deyil. `.vs`, `bin` və `obj` qovluqları `.gitignore` vasitəsilə nəzərə alınmır.
