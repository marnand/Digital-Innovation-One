const cards = document.querySelectorAll('.card')
let hasFlippedCard = false 
let firstCard, secondCard
let lockBoard = false

function flipCard() {
    if (lockBoard) return
    if (this === firstCard) return //impedi que o duplo clique bug o jogo e desvire uma carta que não deve

    this.classList.add('flip')
    if (!hasFlippedCard) {
        hasFlippedCard = true
        firstCard = this
        return
    }

    secondCard = this
    hasFlippedCard = false
    checkForMath()
}

function checkForMath() {
    if (firstCard.dataset.card === secondCard.dataset.card) {
        disableCards()
        return
    }

    unflipCards()
}

function disableCards() {
    firstCard.removeEventListener('click', flipCard)
    secondCard.removeEventListener('click', flipCard)

    resetBoard()
}

function unflipCards() {
    lockBoard = true

    setTimeout(() => {
        firstCard.classList.remove('flip')
        secondCard.classList.remove('flip')

        resetBoard()
    }, 1500)
}

function resetBoard() {
    [hasFlippedCard, lockBoard] = [false, false]
    [firstCard, secondCard] = [null, null]
}

(function shuffle() {
    cards.forEach((card) => {
        let randomPosition = Math.floor(Math.random() * 12)
        card.style.order = randomPosition
    })
})()

cards.forEach((card) => {
    card.addEventListener('click', flipCard)
})

