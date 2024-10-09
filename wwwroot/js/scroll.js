const main = document.getElementById("main");
const speed = 800;

main.addEventListener('wheel', (event) => {
  event.preventDefault();

  main.scrollBy({
    left: event.deltaY < 0 ? -speed : speed,
  });
});
